using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace CoreClient.InjectingCores.MessagingCore.MessageBox
{
    public partial class BaseMessageForm : Form
    {
        protected const string DefaultBackgroundSound = @"C:\Windows\Media\Windows Background.wav";
        protected const string DefaultForegroundSound = @"C:\Windows\Media\Windows Foreground.wav";
        protected string CaptionString { get => Caption.Text; set => Caption.Text = value; }
        protected string MessageString { get => Message.Text; set => Message.Text = value; }
        public BaseMessageForm() => InitializeComponent();
        protected void PlaySound(string source)
        {
            SoundPlayer sp = new SoundPlayer { SoundLocation = source };
            sp.Load();
            sp.Play();
        }
    }
}
