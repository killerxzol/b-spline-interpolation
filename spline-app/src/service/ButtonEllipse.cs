using System.Drawing.Drawing2D;
using System.Windows.Forms;

class ButtonEllipse : Button
{
    protected override void OnPaint(PaintEventArgs e)
    {
        GraphicsPath graphicsPath = new GraphicsPath();
        graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
        this.Region = new System.Drawing.Region(graphicsPath);
        base.OnPaint(e);
    }
}