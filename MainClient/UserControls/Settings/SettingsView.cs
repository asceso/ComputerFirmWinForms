using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Windows.Forms;
using ApplicationModels;
using ClientDataServices;
using CoreClient.ControlExtensions;
using CoreClient.StyleExtensions;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraSplashScreen;
using InjectingCoreLibrary.MapperCore.ClientImplementation;
using InjectingCoreLibrary.MessagingCore.MessageBox;
using InjectingCoreLibrary.SettingsCore;
using InjectingCoreLibrary.SettingsCore.Models;
using MainClient.UserControls.GenericControls;
using Ninject;
using WCFCore.DataContracts;

namespace MainClient.UserControls.Settings
{
    public partial class SettingsView : ContentNoEditUserControlBase
    {
        #region fucking wforms
        public SettingsView() : base() { }
        #endregion
        #region fields
        private IOverlaySplashScreenHandle Loader;
        private BindingSource binding;
        private readonly ISettingsInject settings;
        private readonly IMessageInject message;
        private readonly IMapperInject mapper;

        private SettingsModel settingsModel;
        private bool isPositionsToRequestTypesChanged = false;

        private List<PositionModel> positions;
        private List<RequestTypeModel> requestTypes;
        private List<PermissionModel> permissions;

        private List<PositionPermissionModel> positionPermissionsModels;
        public List<PositionPermissionModel> PositionPermissionModels
        {
            get => positionPermissionsModels ??= new List<PositionPermissionModel>();
            set => positionPermissionsModels = value;
        }
        public PositionPermissionModel SelectedModel { get; set; }

        #endregion
        #region ctor

        public SettingsView(IKernel kernel) : base(kernel)
        {
            InitializeComponent();
            settings = kernel.Get<ISettingsInject>();
            mapper = kernel.Get<IMapperInject>();
            message = kernel.Get<IMessageInject>();
            UpdateComboBoxes();
            mainLayoutPanel.SetDefaultColorForChildren();
            AddPositionPermissionButton.SetDefaultColor();
            DeletePositionPermissionButton.SetDefaultColor();
            settingsModel = settings.ReadConfig();
            TechPosition.SelectedItem = positions.FirstOrDefault(p=>p.Name.Equals(settingsModel.TechnPositionName));

            SaveButton.Click += SaveButtonClick;
            SaveAndExitButton.Click += SaveAndExitClick;
            AddPositionPermissionButton.Click += AddPositionPermissionButtonClick;
            DeletePositionPermissionButton.Click += DeletePositionPermissionButtonClick;
        }
        #endregion
        #region update sources

        private void UpdateComboBoxes()
        {
            #region get sources

            positions = mapper.Map<List<PositionModel>>(PositionsService.GetPositionsCollection().Result.ToList().Where(p => !p.Name.Equals("Администратор")));
            requestTypes = mapper.Map<List<RequestTypeModel>>(RequestTypesService.GetRequestTypeCollection().Result.ToList());
            permissions = mapper.Map<List<PermissionModel>>(PermissionsService.GetPermissionsCollection().Result.ToList());

            #endregion
            #region fill sources

            TechPosition.Properties.Items.AddRange(positions.ToArray());
            PositionComboBox.Properties.Items.AddRange(positions.ToArray());
            AddingPositionCB.Properties.Items.AddRange(positions.ToArray());
            RequestTypesCheckedComboBox.Properties.Items.AddRange(requestTypes.ToArray());
            AddingPermissionCB.Properties.Items.AddRange(permissions.ToArray());

            #endregion
            #region observe data grid

            PositionPermissionModels = mapper.Map<List<PositionPermissionModel>>(PositionPermissionService.GetPositionPermissionsCollection().Result).ToList();

            binding = new BindingSource { DataSource = PositionPermissionModels };
            binding.CurrentChanged += Bind_CurrentChanged;
            PositionPermissionsGrid.DataSource = binding;

            #endregion
        }

        #endregion
        #region observable collection events

        private void Bind_CurrentChanged(object sender, System.EventArgs e)
        {
            if (!(sender is BindingSource bindingSource)) return;
            SelectedModel = bindingSource.Current as PositionPermissionModel;
            DeletePositionPermissionButton.Enabled = !SelectedModel.IsNull();
        }

        #endregion
        #region control events
        private void TechPositionSelectedIndexChanged(object sender, EventArgs e)
            => settingsModel.TechnPositionName = (TechPosition.SelectedItem as PositionModel).Name;
        private void PositionComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            RequestTypesCheckedComboBox.Enabled = !PositionComboBox.SelectedIndex.Equals(-1);

            var position = (PositionModel)PositionComboBox.SelectedItem;
            var checkd = settingsModel.PositionToRequestTypeListDictionary.GetByKey(position.ID);

            if (checkd.IsNull())
            {
                foreach (CheckedListBoxItem item in RequestTypesCheckedComboBox.Properties.Items)
                {
                    item.CheckState = CheckState.Unchecked;
                }
                return;
            }
            foreach (CheckedListBoxItem item in RequestTypesCheckedComboBox.Properties.Items)
            {
                if (checkd.Any(c => c.Equals((item.Value as RequestTypeModel).ID)))
                {
                    item.CheckState = CheckState.Checked;
                }
                else
                {
                    item.CheckState = CheckState.Unchecked;
                }
            }
        }
        private void RequestTypesCheckedComboBox_EditValueChanged(object sender, EventArgs e)
        {
            if (!isPositionsToRequestTypesChanged)
                return;

            var position = (PositionModel)PositionComboBox.SelectedItem;
            List<Guid> newCheckd = new List<Guid>();
            foreach (CheckedListBoxItem item in RequestTypesCheckedComboBox.Properties.Items)
            {
                if (item.CheckState.Equals(CheckState.Checked))
                {
                    newCheckd.Add((item.Value as RequestTypeModel).ID);
                }
            }
            settingsModel.PositionToRequestTypeListDictionary.ReplaceValueByKey(position.ID, newCheckd);

            isPositionsToRequestTypesChanged = false;
        }
        private void RequestTypesCheckedComboBoxQueryCloseUp(object sender, CancelEventArgs e) => isPositionsToRequestTypesChanged = true;
        #endregion
        #region buttons click
        private void SaveButtonClick(object sender, EventArgs e) => settings.SetConfig(settingsModel);
        private void SaveAndExitClick(object sender, EventArgs e)
        {
            SaveButton.PerformClick();
            CloseViewButton.PerformClick();
        }
        private async void DeletePositionPermissionButtonClick(object sender, EventArgs e)
        {
            try
            {
                Loader = this.ShowLoader();
                PositionPermissionsGrid.BeginUpdate();

                if (SelectedModel.IsNull())
                {
                    return;
                }

                PositionPermissionModels.Remove(SelectedModel);
                await PositionPermissionService.DeletePositionPermissions(SelectedModel.ID);
                SelectedModel = null;
                DeletePositionPermissionButton.Enabled = !SelectedModel.IsNull();
            }
            catch (Exception ex)
            {
                message.ShowInfo(ex.Message);
            }
            finally
            {
                PositionPermissionsGrid.EndUpdate();
                this.HideLoader(Loader);
            }
        }
        private void AddPositionPermissionButtonClick(object sender, EventArgs e)
        {
            Loader = this.ShowLoader();
            PositionPermissionsGrid.BeginUpdate();

            PositionPermissionModel model = new PositionPermissionModel()
            {
                ID = Guid.NewGuid(),
                Position = (PositionModel)AddingPositionCB.SelectedItem,
                Permission = (PermissionModel)AddingPermissionCB.SelectedItem
            };
            try
            {
                PositionPermissionModels.Add(model);

                model = mapper.Map<PositionPermissionModel>(PositionPermissionService.InsertPositionPermissions(
                        mapper.Map<PositionPermissionDataContract>(model)).Result);

                SelectedModel = binding.Current as PositionPermissionModel;
            }
            catch (Exception ex)
            {
                if (ex.InnerException is FaultException fe)
                {
                    if (fe.Code.Name.Equals("Insert"))
                    {
                        PositionPermissionModels.Remove(model);
                    }
                    message.ShowInfo(fe.Message);
                }
            }
            finally
            {
                PositionPermissionsGrid.EndUpdate();
                this.HideLoader(Loader);
            }
        }
        #endregion

    }
}
