using System;
using System.Windows.Forms;
using CoreClient.InjectingCores.MessagingCore.MessageBox;
using CoreClient.InjectingCores.SettingsCore;
using CoreClient.StyleExtensions.Animation;
using MainClient.Properties;
using MainClient.Services;
using Ninject;

namespace MainClient.Forms
{
    public partial class AuthForm : Form
    {
        #region injecting
        private readonly ISettingsInject settings;
        private readonly IMessageInject message;
        #endregion
        #region ctor and events
        [Inject]
        public AuthForm(ISettingsInject settings, IMessageInject message)
        {
            AnimatorClass.Start();
            this.settings = settings;
            this.message = message;

            InitializeComponent();
            Icon = Resources.main_icon;
            AuthorizeButton.Enabled = false;

            #if DEBUG
            LoginTE.Value = "admin";
            PasswordTE.Value = "admin";
            AuthorizeButton.Enabled = true;
            AuthorizeButton.Select();
            #endif

            LoginTE.SetTextChangedEvent((s, a) => TextChangedEvent(s, a));
            PasswordTE.SetTextChangedEvent((s, a) => TextChangedEvent(s, a));

            LoginTE.SetKeyPressEvent((s, a) => KeyEnterPressedEvent(s, a));
            PasswordTE.SetKeyPressEvent((s, a) => KeyEnterPressedEvent(s, a));
            AuthorizeButton.Click += AuthorizeButtonClick;
        }
        private void AuthorizeButtonClick(object sender, EventArgs e)
        {
            try
            {
                var user = UsersService.GetUserByLogin(LoginTE.Value);
            }
            catch (Exception ex)
            {
                message.ShowInfo(ex.Message);
            }
            //ShellForm shell = new ShellForm();
            //shell.Show();
        }

        private void CancelButtonClick(object sender, EventArgs e) => Application.Exit();

        private void KeyEnterPressedEvent(object sender, KeyPressEventArgs args)
        {
            if (args.KeyChar.Equals((char)Keys.Enter))
            {
                AuthorizeButton.PerformClick();
            }
        }

        private void TextChangedEvent(object sender, EventArgs args)
            => AuthorizeButton.Enabled =
            !string.IsNullOrEmpty(LoginTE.Value)
            &&
            !string.IsNullOrEmpty(PasswordTE.Value);
        #endregion ctor and events

        #region check auth methods

        #endregion

    }
}
