using System.Windows.Forms;
using CoreClient.StyleExtensions;
using Ninject;

namespace MainClient.UserControls.GenericControls
{
    public partial class ContentUserControlBase : UserControl
    {
        public ContentUserControlBase()
        {
            InitializeComponent();
            BackColor = FormBrushes.WindowBackGroundColor;
            ForeColor = FormBrushes.WindowForegroundColor;
            CloseViewButton.Click += CloseViewButtonClick;
            CollectionView.BackColor = BackColor;
            CollectionView.ForeColor = ForeColor;

            ButtonsPanel.SetDefaultColorForChildren();
        }

        internal readonly IKernel kernel;
        public ContentUserControlBase(IKernel kernel) : this() => this.kernel = kernel;

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
