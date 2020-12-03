using System.Windows.Forms;

namespace CoreClient.ControlExtensions
{
    public static class PictureBoxExtension
    {
        public static void ShowLoader(this PictureBox loader)
        {
            loader.BringToFront();
            loader.Visible = true;
        }
        public static void HideLoader(this PictureBox loader)
        {
            loader.SendToBack();
            loader.Visible = false;
        }
    }
}
