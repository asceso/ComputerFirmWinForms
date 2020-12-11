using System.Windows.Forms;
using CoreClient.StyleExtensions;
using Ninject;

namespace MainClient.UserControls.Requests
{
    public partial class ContentRequestUserControlBase : UserControl
    {
        public ContentRequestUserControlBase()
        {
            InitializeComponent();
            BackColor = FormBrushes.WindowBackGroundColor;
            ForeColor = FormBrushes.WindowForegroundColor;
            ButtonsPanel.SetDefaultColorForChildren();
            MainLayoutTable.SetDefaultColorForChildren();
            CloseViewButton.Click += CloseViewButtonClick;
        }
        public readonly IKernel kernel;
        public ContentRequestUserControlBase(IKernel kernel) : this() => this.kernel = kernel;
        private void CloseViewButtonClick(object sender, System.EventArgs e) => Parent.Dispose();
    }
}
