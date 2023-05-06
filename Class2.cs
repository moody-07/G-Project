using System.Drawing;
using System.Windows.Forms;

public class TransparentPictureBox : PictureBox
{
    public TransparentPictureBox()
    {
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        BackColor = Color.Transparent;
    }
}