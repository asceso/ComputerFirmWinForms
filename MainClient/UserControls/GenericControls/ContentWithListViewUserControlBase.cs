using Ninject;

namespace MainClient.UserControls.GenericControls
{
    public partial class ContentWithListViewUserControlBase : ContentUserControlBase
    {
        public ContentWithListViewUserControlBase() { }

        public ContentWithListViewUserControlBase(IKernel kernel) : base(kernel)
        {
            InitializeComponent();
            CollectionView.BackColor = BackColor;
            CollectionView.ForeColor = ForeColor;
        }
    }
}
