using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.ComponentModel;

namespace Networker
{
    public class NetworkStatistics
    {
        public double Jitter { get; set; }
        public double PacketLoss { get; set; }

        public void CalculatePacketLoss(string ipAddress, int count)
        {
            int failedPings = 0;
            Ping ping = new Ping();

            for (int i = 0; i < count; i++)
            {
                try
                {
                    PingReply reply = ping.Send(ipAddress);
                    if (reply.Status != IPStatus.Success)
                    {
                        failedPings++;
                    }
                }
                catch (PingException ex)
                {
                    // Handle the PingException gracefully
                    Console.WriteLine($"Ping request to {ipAddress} failed: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Handle other types of exceptions, if necessary
                    Console.WriteLine($"An error occurred while pinging {ipAddress}: {ex.Message}");
                }
            }

            PacketLoss = (double)failedPings / count * 100;
        }

        public void CalculateJitter(string ipAddress, int count)
        {
            List<long> roundTripTimes = new List<long>();
            Ping ping = new Ping();

            for (int i = 0; i < count; i++)
            {
                try
                {
                    PingReply reply = ping.Send(ipAddress);
                    if (reply.Status == IPStatus.Success)
                    {
                        roundTripTimes.Add(reply.RoundtripTime);
                    }
                }
                catch (PingException ex)
                {
                    // Handle the PingException gracefully
                    Console.WriteLine($"Ping request to {ipAddress} failed: {ex.Message}");
                }
                catch (Exception ex)
                {
                    // Handle other types of exceptions, if necessary
                    Console.WriteLine($"An error occurred while pinging {ipAddress}: {ex.Message}");
                }
            }

            if (roundTripTimes.Count > 1)
            {
                double totalJitter = 0;
                for (int i = 1; i < roundTripTimes.Count; i++)
                {
                    totalJitter += Math.Abs(roundTripTimes[i] - roundTripTimes[i - 1]);
                }
                Jitter = totalJitter / (roundTripTimes.Count - 1);
            }
            else
            {
                Jitter = 0;
            }
        }
    }
}