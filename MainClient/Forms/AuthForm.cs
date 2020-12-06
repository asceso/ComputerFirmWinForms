using System;
using System.ComponentModel;
using System.Windows.Forms;
using ApplicationModels;
using ClientDataServices;
using CoreClient.ControlExtensions;
using CoreClient.StyleExtensions;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using InjectingCoreLibrary.MapperCore.ClientImplementation;
using InjectingCoreLibrary.MapperCore.MemoryCacheCore;
using InjectingCoreLibrary.MessagingCore.MessageBox;
using InjectingCoreLibrary.SettingsCore;
using MainClient.Properties;
using Ninject;
using WCFCore.DataContracts;
using WCFProxy.Proxy;

namespace MainClient.Forms
{
    public partial class AuthForm : Form, IAuthResult
    {
        #region form settings
        private IOverlaySplashScreenHandle Loader;
        public AuthForm() => InitializeComponent();
        public bool AuthDialogResult { get; set; }

        #endregion
        #region injecting
        private readonly IMessageInject message;
        private readonly IMapperInject mapper;
        private readonly IMemoryInject memory;
        #endregion
        #region ctor
        [Inject]
        public AuthForm(IKernel kernel) : this()
        {
            AuthDialogResult = false;

            TunellProxy.ServiceAddress = kernel.Get<ISettingsInject>().GetServiceName();
            message = kernel.Get<IMessageInject>();
            mapper = kernel.Get<IMapperInject>();
            memory = kernel.Get<IMemoryInject>();

            BackColor = FormBrushes.WindowBackGroundColor;
            ForeColor = FormBrushes.WindowForegroundColor;
            Font = FormBrushes.DefaultRegularFont;

            AuthorizeButton.SetDefaultColor();
            CancelButton.SetDefaultColor();

            Icon = Resources.main_icon;
            AuthorizeButton.Enabled = false;

#if DEBUG
            LoginTE.Text = "admin";
            PasswordTE.Text = "admin";
            PasswordTE.Properties.UseSystemPasswordChar = true;
            AuthorizeButton.Enabled = true;
            AuthorizeButton.Select();
#endif

            LoginTE.TextChanged += TextChangedEvent;
            PasswordTE.TextChanged += TextChangedEvent;

            LoginTE.KeyPress += KeyEnterPressedEvent;
            PasswordTE.KeyPress += KeyEnterPressedEvent;

            AuthorizeButton.Click += AuthorizeButtonClick;
            MouseDown += AuthFormMouseDown;
        }
        #endregion ctor
        #region events
        private void AuthFormMouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
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
        {
            if (sender is TextEdit edit)
            {
                if (edit.Text.Length.Equals(0))
                    edit.Text = null;
            }
            if (sender is TextEdit pass && pass.Name.Equals(nameof(PasswordTE)))
            {
                pass.Properties.UseSystemPasswordChar = !pass.Text.Length.Equals(0);
            }
            AuthorizeButton.Enabled = !string.IsNullOrEmpty(LoginTE.Text) && !string.IsNullOrEmpty(PasswordTE.Text);
        }
        #endregion events
        #region check auth methods
        private void AuthorizeButtonClick(object sender, EventArgs e) => BackAuth.RunWorkerAsync();
        private void BackAuthDoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Loader = this.ShowLoader();
                UserDataContract user = UsersService.GetUserByLogin(LoginTE.Text).Result;
                if (user.IsNull())
                {
                    throw new Exception(
                        "Пользователь не найден в БД." +
                        Environment.NewLine +
                        "Проверьте данные и повторите попытку.");
                }

                if (!user.Password.Equals(PasswordTE.Text))
                {
                    throw new Exception(
                        "Введенный пароль не совпадает с паролем из БД." +
                        Environment.NewLine +
                        "Проверьте данные и повторите попытку.");
                }

                memory.StoreData(mapper.Map<UserDataContract, UserModel>(user), "CurrentUser");
                AuthDialogResult = true;
            }
            catch (Exception ex)
            {
                message.ShowInfo(ex.Message);
            }
            finally
            {
                this.HideLoader(Loader);
            }
        }
        private void BackAuthRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (AuthDialogResult)
            {
                Close();
            }
        }
        #endregion
    }
}
