using System;
using System.Linq;
using ApplicationModels;
using CoreClient.ControlExtensions;
using CoreClient.StyleExtensions;
using MainClient.UserControls.GenericControls;
using Ninject;

namespace MainClient.UserControls.Clients
{
    public partial class ClientsEditView : ContentEditUserControlBase
    {
        #region fucking wforms

        public ClientsEditView() : base() { }

        #endregion

        #region fields

        private bool isAlive = true;
        private ClientModel oldModel;

        private readonly ClientsView parentView;
        private readonly string[] YesNoSource = new string[] { "Да", "Нет" };

        #endregion
        #region props

        #endregion
        #region ctor

        public ClientsEditView(IKernel kernel, ClientsView parentView, ClientModel oldModel) : base(kernel, parentView)
        {
            InitializeComponent();
            this.parentView = parentView;
            this.oldModel = oldModel;
            IsLeadCB.Properties.Items.AddRange(YesNoSource);
            IsDeletedCB.Properties.Items.AddRange(YesNoSource);
            ContactNumberTE.Mask = FormBrushes.ContactNumberMask;

            ResetModel();
            SaveButton.Click += SaveButtonClick;
            DeclineButton.Click += (s, e) => ResetModel();
            SaveAndExit.Click += SaveAndExitClick;
        }

        #endregion
        #region buttons

        private void ResetModel()
        {
            if (oldModel.IsNull())
            {
                return;
            }

            FirstNameTE.Text = oldModel.FirstName.NullableString();
            SecondNameTE.Text = oldModel.SecondName.NullableString();
            LastNameTE.Text = oldModel.LastName.NullableString();
            ContactNumberTE.Text = oldModel.ContactNumber.NullableString();
            IsLeadCB.SelectedItem = oldModel.IsLead.ToPascalString(BooleanExtension.WordsChoise.Да_Нет);
            IsDeletedCB.SelectedItem = oldModel.IsDeleted.ToPascalString(BooleanExtension.WordsChoise.Да_Нет);
        }
        private void SaveButtonClick(object sender, EventArgs e)
        {
            ClientModel newModel = new ClientModel()
            {
                FirstName = FirstNameTE.Text.NullableString(),
                SecondName = SecondNameTE.Text.NullableString(),
                LastName = LastNameTE.Text.NullableString(),
                ContactNumber = ContactNumberTE.Text.NullableString(),
                IsLead = IsLeadCB.SelectedItem.ToString().ToBoolean(StringExtension.WordsChoise.Да_Нет)
            };
            if (oldModel.IsNull())
            {
                newModel.ID = Guid.NewGuid();
                newModel.IsDeleted = false;
                parentView.Models.Add(newModel);
            }
            else
            {
                newModel.ID = oldModel.ID;
                newModel.IsDeleted = oldModel.IsDeleted;
                var model = parentView.Models.FirstOrDefault(m => m.ID.Equals(oldModel.ID));
                parentView.Models[parentView.Models.IndexOf(model)] = newModel;
            }
            if (!isAlive)
            {
                CloseViewButton.PerformClick();
            }
            oldModel = newModel;
        }
        private void SaveAndExitClick(object sender, EventArgs e)
        {
            isAlive = false;
            SaveButton.PerformClick();
        }
        #endregion
    }
}
