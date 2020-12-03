using System;
using System.Windows.Forms;
using ApplicationModels;
using CoreClient.StyleExtensions;
using InjectingCoreLibrary.MessagingCore.MessageBox;

namespace MainClient.Forms
{
    public partial class ChangePasswordForm : Form
    {
        #region Fields and props
        private readonly IMessageInject message;
        public UserModel User { get; private set; }
        public bool PasswordChanged { get; private set; }
        #endregion
        #region Ctor
        public ChangePasswordForm(UserModel user, IMessageInject message)
        {
            InitializeComponent();
            User = user;
            this.message = message;
            BackColor = FormBrushes.WindowBackGroundColor;
            ForeColor = FormBrushes.WindowForegroundColor;
            Font = FormBrushes.DefaultRegularFont;

            OldPassPanel.BackColor = FormBrushes.WindowBackGroundColor;
            OldPassPanel.ForeColor = FormBrushes.WindowForegroundColor;
            OldPassPanel.Font = FormBrushes.DefaultRegularFont;

            NewPassPanel.BackColor = FormBrushes.WindowBackGroundColor;
            NewPassPanel.ForeColor = FormBrushes.WindowForegroundColor;
            NewPassPanel.Font = FormBrushes.DefaultRegularFont;

            ConfPassPanel.BackColor = FormBrushes.WindowBackGroundColor;
            ConfPassPanel.ForeColor = FormBrushes.WindowForegroundColor;
            ConfPassPanel.Font = FormBrushes.DefaultRegularFont;

            OldPassPanel.SetDefaultColorForChildren();
            NewPassPanel.SetDefaultColorForChildren();
            ConfPassPanel.SetDefaultColorForChildren();

            AcceptButton.SetDefaultColor();
            DeclineButton.SetDefaultColor();

            AcceptButton.Click += AcceptButtonClick;
            DeclineButton.Click += DeclineButtonClick;
        }
        #endregion
        #region Buttons
        private void SetResultAndExit(bool result)
        {
            PasswordChanged = result;
            GC.Collect();
            Close();
        }
        private void DeclineButtonClick(object sender, System.EventArgs e) => SetResultAndExit(false);
        private void AcceptButtonClick(object sender, System.EventArgs e)
        {
            if (!User.Password.Equals(OldPasswordBox.Text))
            {
                message.ShowInfo("Старый пароль не совпадает с паролем из базы данных.");
                return;
            }
            if (!NewPasswordBox.Text.Equals(ConfitmPasswordBox.Text))
            {
                message.ShowInfo("Подтвержденный пароль должен быть одинаковым.");
                return;
            }
            User.Password = NewPasswordBox.Text;
            SetResultAndExit(true);
        }
        #endregion
    }
}
