using System.Windows.Forms;
using CoreClient.StyleExtensions;
using Ninject;

namespace MainClient.UserControls
{
    public partial class ContentNoEditUserControlBase : UserControl
    {
        public ContentNoEditUserControlBase()
        {
            InitializeComponent();
            BackColor = FormBrushes.WindowBackGroundColor;
            ForeColor = FormBrushes.WindowForegroundColor;
            ButtonsPanel.SetDefaultColorForChildren();
            CloseViewButton.Click += CloseViewButtonClick;
        }
        internal readonly IKernel kernel;
        public ContentNoEditUserControlBase(IKernel kernel) : this() => this.kernel = kernel;
        private void CloseViewButtonClick(object sender, System.EventArgs e) => Parent.Dispose();
        private void ContentUserControlBaseResize(object sender, System.EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item.Name.Equals(nameof(ContentEditUserControlBase)))
                {
                    item.Size = new System.Drawing.Size((Size.Width / 2) + 100, Size.Height);
                    item.Location = new System.Drawing.Point(Right - item.Size.Width, Top);
                }
            }
        }
    }
}
