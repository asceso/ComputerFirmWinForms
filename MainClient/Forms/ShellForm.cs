using System;
using System.Windows.Forms;
using CoreClient.ControlExtensions;
using CoreClient.ShellModels;
using CoreClient.StyleExtensions;
using CoreClient.StyleExtensions.Animation;
using InjectingCoreLibrary.MapperCore.MemoryCacheCore;
using MainClient.Properties;
using MainClient.UserControls.Users;
using Ninject;
using PermissionsManager;

namespace MainClient.Forms
{
    public partial class ShellForm : Form
    {
        private enum ControlNames
        {
            UsersView, ClientsView
        }

        private enum ControlHeaders
        {
            Сотрудники, Клиенты
        }
        private string GetRusName(ControlHeaders selectedEnum)
            => Enum.GetName(typeof(ControlHeaders), selectedEnum).Replace("_", " ");

        private readonly IKernel kernel;
        public ShellForm(IKernel kernel)
        {
            this.kernel = kernel;
            AnimatorClass.Start();
            InitializeComponent();
            BackColor = FormBrushes.WindowBackGroundColor;
            ForeColor = FormBrushes.WindowForegroundColor;
            Font = FormBrushes.DefaultRegularFont;

            ButtonsPanel.SetDefaultColorForChildren();

            WindowState = FormWindowState.Maximized;

            AuthForm auth = new AuthForm(kernel);
            auth.ShowDialog();
            if (!auth.AuthDialogResult)
            {
                Application.Exit();
            }
            else
            {
                UserModel currentUser = kernel.Get<IMemoryInject>().GetData<UserModel>("CurrentUser");
                kernel.Get<IPermissionInject>().RegisterPermissionsForUser(kernel, currentUser);
                Text = $"Компьютерная фирма, текущий пользователь : " +
                       $"{currentUser.Login}";
                Icon = Resources.main_icon;
            }

            UsersButton.SetVisibleByPermissionStatus(kernel.Get<IPermissionInject>().IsHasPermission("UsersGet"));
            ClientsButton.SetVisibleByPermissionStatus(kernel.Get<IPermissionInject>().IsHasPermission("ClientsGet"));
        }

        #region buttons
        private void UsersButtonClick(object sender, EventArgs e)
            => SwitchTabButton(nameof(ControlNames.UsersView), GetRusName(ControlHeaders.Сотрудники));

        private void ClientsButtonClick(object sender, EventArgs e)
            => SwitchTabButton(nameof(ControlNames.ClientsView), GetRusName(ControlHeaders.Клиенты));

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
                case nameof(ControlNames.UsersView):
                    return new UsersView(kernel);
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
