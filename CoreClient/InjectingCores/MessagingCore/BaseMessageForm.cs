using System.Media;
using System.Windows.Forms;
using CoreClient.StyleExtensions;

namespace CoreClient.InjectingCores.MessagingCore.MessageBox
{
    public partial class BaseMessageForm : Form
    {
        protected const string DefaultBackgroundSound = @"C:\Windows\Media\Windows Background.wav";
        protected const string DefaultForegroundSound = @"C:\Windows\Media\Windows Foreground.wav";
        protected string CaptionString { get => Caption.Text; set => Caption.Text = value; }
        protected string MessageString { get => Message.Text; set => Message.Text = value; }
        public BaseMessageForm()
        {
            InitializeComponent();
            BackColor = FormBrushes.WindowBackGroundColor;
            ForeColor = FormBrushes.WindowForegroundColor;
            Font = FormBrushes.DefaultRegularFont;
            Message.BackColor = FormBrushes.WindowBackGroundColor;
            Message.ForeColor = FormBrushes.WindowForegroundColor;
            Message.Font = FormBrushes.DefaultRegularFont;
            Caption.BackColor = FormBrushes.WindowBackGroundColor;
            Caption.ForeColor = FormBrushes.WindowForegroundColor;
            Caption.Font = FormBrushes.DefaultRegularFont;
        }
        protected void PlaySound(string source)
        {
            SoundPlayer sp = new SoundPlayer { SoundLocation = source };
            sp.Load();
            sp.Play();
        }
    }
}
