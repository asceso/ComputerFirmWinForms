using CoreClient.ControlExtensions;

namespace CoreClient.InjectingCores.MessagingCore.MessageBox
{
    public partial class MessageInjectForm : BaseMessageForm, IMessageInject
    {
        public MessageInjectForm()
        {
            InitializeComponent();
            OKButton.Click += OKButtonClick;
        }
        private void OKButtonClick(object sender, System.EventArgs e) => Hide();
        public void ShowInfo(string message, string caption = null)
        {
            CaptionString = caption.IsNull() ? "Внимание" : caption;
            PlaySound(DefaultBackgroundSound);
            MessageString = message;
            Show();
        }
    }
}
