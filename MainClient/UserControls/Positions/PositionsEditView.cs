using System;
using System.Windows.Forms;
using ApplicationModels;
using ClientDataServices;
using CoreClient.ControlExtensions;
using InjectingCoreLibrary.MapperCore.ClientImplementation;
using MainClient.UserControls.GenericControls;
using Ninject;
using WCFCore.DataContracts;

namespace MainClient.UserControls.Positions
{
    public partial class PositionsEditView : ContentEditUserControlBase
    {
        #region fucking wforms
        public PositionsEditView() : base() { }
        #endregion

        #region elem names
        private const string NameTextBox = nameof(NameTextBox);
        private const string DescriptionTextBox = nameof(DescriptionTextBox);
        #endregion
        #region header names
        private const string NameHeader = "Название";
        private const string DescriptionHeader = "Описание";
        #endregion
        #region fields

        private readonly IMapperInject mapper;
        private readonly PositionsView baseControl;
        private PositionModel OldModel;

        #endregion
        #region ctor
        public PositionsEditView(IKernel kernel, PositionsView baseControl, PositionModel model) : base(kernel, baseControl)
        {
            this.baseControl = baseControl;
            mapper = kernel.Get<IMapperInject>();

            OldModel = model;

            InitElements(model);
            ResetModel(model);
            DeclineButton.Click += (s, e) => ResetModel(OldModel);
            SaveButton.Click += (s, e) => OnSaveMethod(true);
            SaveAndExit.Click += (s, e) => OnSaveMethod(false);
        }
        #endregion
        #region init heads
        private void InitElements(PositionModel model)
        {
            int lastTabulation = 2;
            ContentPanel.CreateTextBoxWithLabel(DescriptionTextBox, DescriptionHeader, lastTabulation--);
            ContentPanel.CreateTextBoxWithLabel(NameTextBox, NameHeader, lastTabulation--);
        }
        #endregion
        #region reset model
        private void ResetModel(PositionModel model)
        {
            if (model.IsNull())
            {
                return;
            }

            foreach (Control item in ContentPanel.Controls)
            {
                if (item is TextBox textBox)
                {
                    switch (textBox.Name)
                    {
                        case NameTextBox:
                            textBox.Text = model.Name;
                            break;
                        case DescriptionTextBox:
                            textBox.Text = model.Description;
                            break;
                    }
                }
            }
        }
        #endregion
        #region methods
        private void OnSaveMethod(bool IsAlive)
        {
            string nameTemp = ContentPanel.GetFormControlFromPanel<TextBox>(NameTextBox).Text;
            string descriptionTemp = ContentPanel.GetFormControlFromPanel<TextBox>(DescriptionTextBox).Text;

            PositionModel NewModel = new PositionModel
            {
                Name = nameTemp,
                Description = descriptionTemp
            };

            PositionDataContract changes = new PositionDataContract();
            int selectedModel = baseControl.Models.IndexOf(OldModel);

            if (OldModel.IsNull())
            {
                NewModel.ID = Guid.NewGuid();
                changes = PositionsService.InsertPosition(mapper.Map<PositionModel, PositionDataContract>(NewModel)).Result;
                baseControl.Models.Add(mapper.Map<PositionDataContract, PositionModel>(changes));
            }
            else
            {
                NewModel.ID = baseControl.Models[selectedModel].ID;
                changes = PositionsService.UpdatePosition(mapper.Map<PositionModel, PositionDataContract>(NewModel)).Result;
                baseControl.Models[selectedModel] = mapper.Map<PositionDataContract, PositionModel>(changes);

                baseControl.CollectionView.Items[selectedModel].Selected = true;
            }

            if (IsAlive)
            {
                OldModel = selectedModel.Equals(-1) ? baseControl.Models[baseControl.Models.Count - 1] : baseControl.Models[selectedModel];
            }
            else
            {
                CloseViewButton.PerformClick();
            }
        }
        #endregion
    }
}
