using System.Windows.Forms;

public partial class SmootherPanel : Panel
{
    public SmootherPanel() : base()
    {
        this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
    }
}
