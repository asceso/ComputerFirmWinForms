using System;
using System.Windows.Forms;
using ApplicationModels;
using ClientDataServices;
using CoreClient.ControlExtensions;
using InjectingCoreLibrary.MapperCore.ClientImplementation;
using MainClient.UserControls.GenericControls;
using Ninject;
using WCFCore.DataContracts;

namespace MainClient.UserControls.RequestTypes
{
    public partial class RequestTypesEditView : ContentEditUserControlBase
    {
        #region fucking wforms
        public RequestTypesEditView() : base() { }
        #endregion

        #region elem names
        private const string RequestNameTextBox = nameof(RequestNameTextBox);
        private const string DescriptionTextBox = nameof(DescriptionTextBox);
        #endregion
        #region header names
        private const string RequestNameHeader = "Название типа заявки";
        private const string DescriptionHeader = "Описание";
        #endregion
        #region fields

        private readonly IMapperInject mapper;
        private readonly RequestTypesView baseControl;
        private RequestTypeModel OldModel;

        #endregion
        #region ctor
        public RequestTypesEditView(IKernel kernel, RequestTypesView baseControl, RequestTypeModel model) : base(kernel, baseControl)
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
        private void InitElements(RequestTypeModel model)
        {
            int lastTabulation = 2;
            ContentPanel.CreateTextBoxWithLabel(DescriptionTextBox, DescriptionHeader, lastTabulation--);
            ContentPanel.CreateTextBoxWithLabel(RequestNameTextBox, RequestNameHeader, lastTabulation--);
        }
        #endregion
        #region reset model
        private void ResetModel(RequestTypeModel model)
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
                        case RequestNameTextBox:
                            textBox.Text = model.RequestName;
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
            string requestNameTemp = ContentPanel.GetFormControlFromPanel<TextBox>(RequestNameTextBox).Text;
            string descriptionTemp = ContentPanel.GetFormControlFromPanel<TextBox>(DescriptionTextBox).Text;

            RequestTypeModel NewModel = new RequestTypeModel
            {
                RequestName = requestNameTemp,
                Description = descriptionTemp
            };

            RequestTypeDataContract changes = new RequestTypeDataContract();
            int selectedModel = baseControl.Models.IndexOf(OldModel);

            if (OldModel.IsNull())
            {
                NewModel.ID = Guid.NewGuid();
                changes = RequestTypesService.InsertRequestType(mapper.Map<RequestTypeModel, RequestTypeDataContract>(NewModel)).Result;
                baseControl.Models.Add(mapper.Map<RequestTypeDataContract, RequestTypeModel>(changes));
            }
            else
            {
                NewModel.ID = baseControl.Models[selectedModel].ID;
                changes = RequestTypesService.UpdateRequestType(mapper.Map<RequestTypeModel, RequestTypeDataContract>(NewModel)).Result;
                baseControl.Models[selectedModel] = mapper.Map<RequestTypeDataContract, RequestTypeModel>(changes);

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
