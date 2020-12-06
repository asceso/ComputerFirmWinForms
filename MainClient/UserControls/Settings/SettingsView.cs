using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ApplicationModels;
using ClientDataServices;
using CoreClient.ControlExtensions;
using DevExpress.XtraEditors.Controls;
using InjectingCoreLibrary.MapperCore.ClientImplementation;
using InjectingCoreLibrary.SettingsCore;
using InjectingCoreLibrary.SettingsCore.Models;
using MainClient.UserControls.GenericControls;
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
        private readonly IMapperInject mapper;

        private SettingsModel settingsModel;
        private bool isPositionsToRequestTypesChanged = false;

        private List<PositionModel> positions;
        private List<RequestTypeModel> requestTypes;
        #endregion
        #region ctor

        public SettingsView(IKernel kernel) : base(kernel)
        {
            InitializeComponent();
            settings = kernel.Get<ISettingsInject>();
            mapper = kernel.Get<IMapperInject>();
            UpdateComboBoxes();
            settingsModel = settings.ReadConfig();

            SaveButton.Click += SaveButtonClick;
            SaveAndExitButton.Click += SaveAndExitClick;
        }
        #endregion
        #region update sources
        private void UpdateComboBoxes()
        {
            //get sources
            positions = mapper.Map<List<PositionModel>>(PositionsService.GetPositionsCollection().Result.ToList().Where(p => !p.Name.Equals("Администратор")));
            requestTypes = mapper.Map<List<RequestTypeModel>>(RequestTypesService.GetRequestTypeCollection().Result.ToList());

            foreach (PositionModel position in positions)
            {
                PositionComboBox.Properties.Items.Add(position);
            }
            foreach (RequestTypeModel requestType in requestTypes)
            {
                RequestTypesCheckedComboBox.Properties.Items.Add(requestType);
            }
        }
        #endregion
        #region control events
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
                if (checkd.Any(c=> c.Equals((item.Value as RequestTypeModel).ID)))
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
        #endregion
    }
}
