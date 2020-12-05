using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Forms;
using ApplicationModels;
using ClientDataServices;
using CoreClient.ControlExtensions;
using InjectingCoreLibrary.MapperCore.ClientImplementation;
using InjectingCoreLibrary.MessagingCore.AskBox;
using InjectingCoreLibrary.MessagingCore.MessageBox;
using Ninject;
using PermissionsManager;
using WCFCore.DataContracts;

namespace MainClient.UserControls.Positions
{
    public partial class PositionsView : ContentUserControlBase
    {
        #region fucking wforms
        public PositionsView() : base() { }
        #endregion

        #region Fields

        private readonly IMapperInject mapper;
        private ObservableCollection<PositionModel> models;

        #endregion
        #region Props

        public ObservableCollection<PositionModel> Models
        {
            get => models ??= new ObservableCollection<PositionModel>();
            set => models = value;
        }

        #endregion
        #region Ctor

        public PositionsView(IKernel kernel) : base(kernel)
        {
            CollectionView.MultiSelect = false;
            mapper = kernel.Get<IMapperInject>();
            InitHeaders();
            UpdateCollection(true);

            AddButton.Click += AddButtonClick;
            EditButton.Click += EditButtonClick;
            CollectionView.MouseDoubleClick += CollectionViewMouseDoubleClick;
            DeleteButton.Click += DeleteButtonClickAsync;

            AddButton.SetVisibleByPermissionStatus(kernel.Get<IPermissionInject>().IsHasPermission("PositionsIns"));
            EditButton.SetVisibleByPermissionStatus(kernel.Get<IPermissionInject>().IsHasPermission("PositionsUpd"));
            DeleteButton.SetVisibleByPermissionStatus(kernel.Get<IPermissionInject>().IsHasPermission("PositionsDel"));
        }

        #endregion
        #region Update collection

        private void InitHeaders()
        {
            CollectionView.Columns.Add("Название", 300);
            CollectionView.Columns.Add("Описание", 300);
        }
        internal void UpdateCollection(bool modify)
        {
            if (!modify)
            {
                return;
            }

            IEnumerable<PositionDataContract> dataPositions = (PositionsService.GetPositionsCollection().Result);
            IEnumerable<PositionModel> positions = kernel.Get<IMapperInject>().Map<IEnumerable<PositionDataContract>, IEnumerable<PositionModel>>(dataPositions);
            Models = new ObservableCollection<PositionModel>();
            Models.CollectionChanged += ModelsCollectionChanged;
            foreach (PositionModel position in positions)
            {
                Models.Add(position);
            }
        }

        #endregion
        #region Buttons

        private async void DeleteButtonClickAsync(object sender, System.EventArgs e)
        {
            if (CollectionView.SelectedIndices.Count.Equals(0))
            {
                return;
            }

            if (kernel.Get<IAskInject>()
                    .ShowQuestion($"Будет удалено {CollectionView.SelectedIndices.Count} записей. Продолжить?")
                    .Equals(DialogResult.No))
            {
                return;
            }

            //remove single
            if (CollectionView.SelectedIndices.Count.Equals(1))
            {
                PositionModel RemovedModel = Models[CollectionView.SelectedIndices[0]];
                int removed = await PositionsService.DeletePosition(mapper.Map<PositionModel, PositionDataContract>(RemovedModel));
                Models.Remove(RemovedModel);
                kernel.Get<IMessageInject>().ShowInfo($"Удалено {removed} записей.");
                return;
            }

            //remove many
            if (CollectionView.SelectedIndices.Count > 1)
            {

            }
        }
        private void AddButtonClick(object sender, System.EventArgs e)
        {
            Controls.Add(new PositionsEditView(kernel, this, null));
            Control edit = Controls.Find(nameof(ContentEditUserControlBase), false).FirstOrDefault();
            edit.Location = new System.Drawing.Point(Right - edit.Size.Width, Top);
            edit.BringToFront();
            ButtonsPanel.Enabled = false;
            ContentPanel.Enabled = false;
        }
        private void CollectionViewMouseDoubleClick(object sender, MouseEventArgs e) => EditButton.PerformClick();
        private void EditButtonClick(object sender, System.EventArgs e)
        {
            if (CollectionView.SelectedIndices.Count.Equals(0))
            {
                return;
            }

            Controls.Add(new PositionsEditView(kernel, this, Models[CollectionView.SelectedIndices[0]]));
            Control edit = Controls.Find(nameof(ContentEditUserControlBase), false).FirstOrDefault();
            edit.Location = new System.Drawing.Point(Right - edit.Size.Width, Top);
            edit.BringToFront();
            ButtonsPanel.Enabled = false;
            ContentPanel.Enabled = false;
        }

        #endregion
        #region Observe collection event

        private void ModelsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    {
                        if (e.NewItems[0] is PositionModel position)
                        {
                            string[] collectionItem = new string[]
                            {
                                position.Name,
                                position.Description,
                            };
                            CollectionView.Items.Add(new ListViewItem(collectionItem));
                        }
                    }
                    break;
                case NotifyCollectionChangedAction.Replace:
                    {
                        int insertIndex = -1;
                        if (e.OldItems[0] is PositionModel oldUser)
                        {
                            insertIndex = Models.IndexOf(Models.FirstOrDefault(u => u.ID.Equals(oldUser.ID)));
                            CollectionView.Items.RemoveAt(insertIndex);
                        }
                        if (e.NewItems[0] is PositionModel position)
                        {
                            string[] collectionItem = new string[]
                            {
                                position.Name,
                                position.Description,
                            };
                            CollectionView.Items.Insert(insertIndex, new ListViewItem(collectionItem));
                        }
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    {
                        int removeIndex = e.OldStartingIndex;
                        if (e.OldItems[0] is PositionModel)
                        {
                            CollectionView.Items.RemoveAt(removeIndex);
                        }
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    {
                        CollectionView.Items.Clear();
                        UpdateCollection(true);
                    }
                    break;
            }
        }

        #endregion
    }
}
