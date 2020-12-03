using System;
using System.ComponentModel;
using System.Windows.Forms;
using ApplicationModels;
using ClientDataServices;
using CoreClient.ControlExtensions;
using CoreClient.StyleExtensions;
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
        public AuthForm() => InitializeComponent();
        public bool AuthDialogResult { get; set; }
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
            => AuthorizeButton.Enabled =
            !string.IsNullOrEmpty(LoginTE.Value)
            &&
            !string.IsNullOrEmpty(PasswordTE.Value);
        #endregion events
        #region check auth methods
        private void AuthorizeButtonClick(object sender, EventArgs e) => BackAuth.RunWorkerAsync();
        private void BackAuthDoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Invoke((MethodInvoker)(() => LoaderBox.ShowLoader()));
                UserDataContract user = UsersService.GetUserByLogin(LoginTE.Value).Result;
                if (user.IsNull())
                {
                    throw new Exception(
                        "Пользователь не найден в БД." +
                        Environment.NewLine +
                        "Проверьте данные и повторите попытку.");
                }

                if (!user.Password.Equals(PasswordTE.Value))
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
        }
        private void BackAuthRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            LoaderBox.HideLoader();
            if (AuthDialogResult)
            {
                Close();
            }
        }
        #endregion
    }
}
