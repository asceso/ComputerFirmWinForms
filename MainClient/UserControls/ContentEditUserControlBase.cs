using System.Windows.Forms;
using CoreClient.StyleExtensions;
using Ninject;

namespace MainClient.UserControls
{
    public partial class ContentEditUserControlBase : UserControl
    {
        public ContentEditUserControlBase()
        {
            InitializeComponent();
            BackColor = FormBrushes.WindowBackGroundColor;
            ForeColor = FormBrushes.WindowForegroundColor;
            ButtonsPanel.SetDefaultColorForChildren();
        }
        private readonly ContentUserControlBase baseControl;
        public ContentEditUserControlBase(IKernel kernel, ContentUserControlBase baseControl) : this()
        {
            this.baseControl = baseControl;
            if (!(baseControl is null))
            {
                Size = new System.Drawing.Size(baseControl.Size.Width / 2, baseControl.Size.Height);
            }
        }
        private void CloseViewButtonClick(object sender, System.EventArgs e)
        {
            if (!(baseControl is null))
            {
                baseControl.ButtonsPanel.Enabled = true;
                baseControl.ContentPanel.Enabled = true;
                Dispose();
            }
            else
            {
                Parent.Dispose();
            }
        }
    }
}
