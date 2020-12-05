using InjectingCoreLibrary.SettingsCore;
using Ninject;

namespace MainClient.UserControls.Settings
{
    public partial class SettingsView : ContentNoEditUserControlBase
    {
        #region fucking wforms
        public SettingsView() : base() { }
        #endregion
        #region fields
        private readonly ISettingsInject settings;
        #endregion
        #region ctor

        public SettingsView(IKernel kernel) : base(kernel)
        {
            InitializeComponent();
            settings = kernel.Get<ISettingsInject>();
            SaveButton.Click += SaveButtonClick;
            SaveAndExitButton.Click += SaveAndExitClick;
        }

        #endregion
        #region buttons click
        private void SaveButtonClick(object sender, System.EventArgs e)
        {

        }
        private void SaveAndExitClick(object sender, System.EventArgs e)
        {
            SaveButton.PerformClick();
            CloseViewButton.PerformClick();
        }
        #endregion
    }
}
