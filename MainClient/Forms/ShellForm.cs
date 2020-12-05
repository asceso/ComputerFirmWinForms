using System;
using System.Windows.Forms;
using ApplicationModels;
using CoreClient.ControlExtensions;
using CoreClient.StyleExtensions;
using CoreClient.StyleExtensions.Animation;
using InjectingCoreLibrary.MapperCore.MemoryCacheCore;
using MainClient.Properties;
using MainClient.UserControls.Positions;
using MainClient.UserControls.RequestTypes;
using MainClient.UserControls.Settings;
using MainClient.UserControls.Users;
using Ninject;
using PermissionsManager;

namespace MainClient.Forms
{
    public partial class ShellForm : Form
    {
        #region enums

        private enum ControlNames
        {
            SettingsView, UsersView, PositionsView, RequestTypesView, ClientsView
        }

        private enum ControlHeaders
        {
            Настройки, Сотрудники, Должности, Типы_заявок, Клиенты
        }
        private string GetRusHeaderName(ControlHeaders selectedEnum)
            => Enum.GetName(typeof(ControlHeaders), selectedEnum).Replace("_", " ");

        #endregion
        #region fields

        private readonly IKernel kernel;
        private readonly IPermissionInject permissionManager;

        #endregion
        #region ctor

        public ShellForm(IKernel kernel)
        {
            #region init
            this.kernel = kernel;
            permissionManager = kernel.Get<IPermissionInject>();
            AnimatorClass.Start();
            InitializeComponent();
            SetupStyles();
            #endregion
            #region do auth
            AuthForm auth = new AuthForm(kernel);
            auth.ShowDialog();
            if (!auth.AuthDialogResult)
            {
                Environment.Exit(0);
            }
            #endregion
            #region after auth init
            //get cache
            UserModel currentUser = kernel.Get<IMemoryInject>().GetData<UserModel>("CurrentUser");
            //register permissions
            kernel.Get<IPermissionInject>().RegisterPermissionsForUser(kernel, currentUser);
            //set after styles and events
            Text = $"Компьютерная фирма, текущий пользователь : " +
                    $"{currentUser.Login}";
            Icon = Resources.main_icon;
            SetupButtons();
            #endregion
        }
        private void SetupStyles()
        {
            BackColor = FormBrushes.WindowBackGroundColor;
            ForeColor = FormBrushes.WindowForegroundColor;
            Font = FormBrushes.DefaultRegularFont;
            ButtonsPanel.SetDefaultColorForChildren();
            WindowState = FormWindowState.Maximized;
        }

        #endregion
        #region buttons
        #region add events and accept permissions

        private void SetupButtons()
        {
            #region events add

            SettingsButton.Click += SettingsButtonClick;
            UsersButton.Click += UsersButtonClick;
            PositionsButton.Click += PositionsButtonClick;
            RequestTypesButton.Click += RequestTypesButtonClick;
            ClientsButton.Click += ClientsButtonClick;

            #endregion
            #region permissions check

            UsersButton.SetVisibleByPermissionStatus(permissionManager.IsHasPermission("UsersGet"));
            PositionsButton.SetVisibleByPermissionStatus(permissionManager.IsHasPermission("PositionsGet"));
            RequestTypesButton.SetVisibleByPermissionStatus(permissionManager.IsHasPermission("RequestTypesGet"));
            ClientsButton.SetVisibleByPermissionStatus(permissionManager.IsHasPermission("ClientsGet"));

            #endregion
        }

        #endregion
        #region button events

        private void SettingsButtonClick(object sender, EventArgs e)
            => SwitchTabButton(nameof(ControlNames.SettingsView), GetRusHeaderName(ControlHeaders.Настройки));

        private void UsersButtonClick(object sender, EventArgs e)
            => SwitchTabButton(nameof(ControlNames.UsersView), GetRusHeaderName(ControlHeaders.Сотрудники));

        private void PositionsButtonClick(object sender, EventArgs e)
            => SwitchTabButton(nameof(ControlNames.PositionsView), GetRusHeaderName(ControlHeaders.Должности));

        private void RequestTypesButtonClick(object sender, EventArgs e)
            => SwitchTabButton(nameof(ControlNames.RequestTypesView), GetRusHeaderName(ControlHeaders.Типы_заявок));

        private void ClientsButtonClick(object sender, EventArgs e)
            => SwitchTabButton(nameof(ControlNames.ClientsView), GetRusHeaderName(ControlHeaders.Клиенты));

        #endregion
        #endregion
        #region tab control methods

        private void SwitchTabButton(string Name, string Header)
        {
            if (ContentTabControl.HasPage(Name))
            {
                ContentTabControl.SetPageByName(Name);
            }
            else
            {
                ContentTabControl.AddAndSelectTab(Name, Header);
            }

            TabPage page = ContentTabControl.GetPageByName(Name);
            if (page.Controls.Count.Equals(0))
            {
                page.Controls.Add(GetControlByName(Name));
            }

            foreach (Control item in page.Controls)
            {
                item.Size = page.Size;
            }
        }
        private UserControl GetControlByName(string Name)
        {
            switch (Name)
            {
                case nameof(ControlNames.SettingsView):
                    return new SettingsView(kernel);
                case nameof(ControlNames.UsersView):
                    return new UsersView(kernel);
                case nameof(ControlNames.PositionsView):
                    return new PositionsView(kernel);
                case nameof(ControlNames.RequestTypesView):
                    return new RequestTypesView(kernel);
                case nameof(ControlNames.ClientsView):
                    break;
            }
            return null;
        }

        #endregion
        #region resize shell
        private void ShellFormResize(object sender, EventArgs e)
        {
            foreach (TabPage page in ContentTabControl.TabPages)
            {
                foreach (Control item in page.Controls)
                {
                    item.Size = page.Size;
                }
            }
        }
        #endregion
    }
}
