using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ApplicationModels;
using ClientDataServices;
using CoreClient.ControlExtensions;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using InjectingCoreLibrary.MapperCore.ClientImplementation;
using InjectingCoreLibrary.MessagingCore.AskBox;
using InjectingCoreLibrary.MessagingCore.MessageBox;
using MainClient.UserControls.GenericControls;
using Ninject;
using PermissionsManager;
using WCFCore.DataContracts;

namespace MainClient.UserControls.Clients
{
    public partial class ClientsView : ContentUserControlBase
    {
        #region fucking wforms

        public ClientsView() : base() { }

        #endregion
        #region fields

        private BindingSource binding;
        private IOverlaySplashScreenHandle Loader;
        private readonly IMapperInject mapper;
        private readonly IAskInject asker;
        private readonly IMessageInject message;

        #endregion
        #region props

        private ObservableCollection<ClientModel> models;

        public ObservableCollection<ClientModel> Models
        {
            get => models ??= new ObservableCollection<ClientModel>();
            set => models = value;
        }
        public ClientModel SelectedModel { get; set; }

        #endregion
        #region ctor

        public ClientsView(IKernel kernel) : base(kernel)
        {
            InitializeComponent();
            ClientsGrid.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            mapper = kernel.Get<IMapperInject>();
            asker = kernel.Get<IAskInject>();
            message = kernel.Get<IMessageInject>();
            UpdateCollection();

            AddButton.Click += AddButtonClick;
            EditButton.Click += EditButtonClick;
            DeleteButton.Click += DeleteButtonClick;
            ClientsGrid.MouseDoubleClick += (s, e) => EditButton.PerformClick();

            IPermissionInject permissionManager = kernel.Get<IPermissionInject>();
            AddButton.SetVisibleByPermissionStatus(permissionManager.IsHasPermission("ClientsIns"));
            EditButton.SetVisibleByPermissionStatus(permissionManager.IsHasPermission("ClientsUpd"));
            DeleteButton.SetVisibleByPermissionStatus(permissionManager.IsHasPermission("ClientsDel"));
        }
        private void UpdateCollection()
        {
            Models = mapper.Map<IEnumerable<ClientModel>>(ClientsService.GetClientsCollection().Result)
                .ToObservableCollection(ModelsCollectionChanged);

            binding = new BindingSource { DataSource = Models };
            binding.CurrentChanged += Bind_CurrentChanged;
            ClientsGrid.DataSource = binding;
        }
        private void Bind_CurrentChanged(object sender, System.EventArgs e)
        {
            if (!(sender is BindingSource bindingSource)) return;
            SelectedModel = bindingSource.Current as ClientModel;

            EditButton.Enabled = !SelectedModel.IsNull();
            DeleteButton.Enabled = !SelectedModel.IsNull();
        }
        private void GridRowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle.Equals(-1))
            {
                return;
            }
            if (View.GetRowCellValue(e.RowHandle, View.Columns["IsDeleted"]).ToString().Equals("True"))
            {
                e.Appearance.BackColor = Color.FromArgb(105, 105, 105);
            }
        }

        #endregion
        #region observe events

        private void ModelsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            try
            {
                Loader = this.ShowLoader();
                ClientsGrid.BeginUpdate();
                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add:
                        {
                            ClientDataContract changes = ClientsService.InsertClient(mapper.Map<ClientDataContract>(e.NewItems[0] as ClientModel)).Result;
                        }
                        break;
                    case NotifyCollectionChangedAction.Replace:
                        {
                            ClientDataContract changes = ClientsService.UpdateClient(mapper.Map<ClientDataContract>(e.NewItems[0] as ClientModel)).Result;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                message.ShowInfo(ex.Message, "Ошибка");
            }
            finally
            {
                ClientsGrid.EndUpdate();
                SelectedModel = binding.Current as ClientModel;
                this.HideLoader(Loader);
            }
        }

        #endregion
        #region buttons click

        private void AddButtonClick(object sender, System.EventArgs e)
        {
            Controls.Add(new ClientsEditView(kernel, this, null));
            Control edit = Controls.Find(nameof(ClientsEditView), false).FirstOrDefault();
            edit.Location = new System.Drawing.Point(Right - edit.Size.Width, Top);
            edit.BringToFront();
            ButtonsPanel.Enabled = false;
            ContentPanel.Enabled = false;
        }
        private void EditButtonClick(object sender, System.EventArgs e)
        {
            Controls.Add(new ClientsEditView(kernel, this, SelectedModel));
            Control edit = Controls.Find(nameof(ClientsEditView), false).FirstOrDefault();
            edit.Location = new System.Drawing.Point(Right - edit.Size.Width, Top);
            edit.BringToFront();
            ButtonsPanel.Enabled = false;
            ContentPanel.Enabled = false;
        }
        private void DeleteButtonClick(object sender, System.EventArgs e)
        {
            if (!asker.ShowQuestion("Запись будет перемещена в архив, продолжить?").Equals(DialogResult.Yes))
            {
                return;
            }
            ClientModel deleted = SelectedModel;
            deleted.IsDeleted = true;
            Models[Models.IndexOf(SelectedModel)] = deleted;
        }

        #endregion
    }
}
