using System;
using System.Windows.Forms;
using CoreClient.ControlExtensions;
using CoreClient.StyleExtensions;

namespace InjectingCoreLibrary.MessagingCore.AskBox
{
    public partial class AskInjectForm : BaseMessageForm, IAskInject
    {
        private DialogResult QuestionResult;
        public AskInjectForm()
        {
            InitializeComponent();
            YesButton.SetDefaultColor();
            NoButton.SetDefaultColor();
        }

        public DialogResult ShowQuestion(string message, string caption = null)
        {
            CaptionString = caption.IsNull() ? "Подтвердите действие" : caption;
            PlaySound(DefaultBackgroundSound);
            MessageString = message;
            ShowDialog();
            return QuestionResult;
        }
        private void YesButtonClick(object sender, EventArgs e)
        {
            QuestionResult = DialogResult.Yes;
            Hide();
        }
        private void NoButtonClick(object sender, EventArgs e)
        {
            QuestionResult = DialogResult.No;
            Hide();
        }
    }
}
