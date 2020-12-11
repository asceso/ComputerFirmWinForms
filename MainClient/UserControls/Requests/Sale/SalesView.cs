using System;
using CoreClient.StyleExtensions;
using Ninject;

namespace MainClient.UserControls.Requests.Sale
{
    public partial class SalesView : DevExpress.XtraEditors.XtraUserControl
    {
        public SalesView(IKernel kernel)
        {
            InitializeComponent();
            BackColor = FormBrushes.WindowBackGroundColor;
            ForeColor = FormBrushes.WindowForegroundColor;
            ButtonsPanel.SetDefaultColorForChildren();
            MainLayoutTable.SetDefaultColorForChildren();
            CloseViewButton.Click += CloseViewButtonClick;
        }
        private void CloseViewButtonClick(object sender, EventArgs e) => Parent.Dispose();
    }
}
