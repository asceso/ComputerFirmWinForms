using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClientDataServices;
using CoreClient.ControlExtensions;
using CoreClient.ShellModels;
using InjectingCoreLibrary.MapperCore.ClientImplementation;
using InjectingCoreLibrary.MessagingCore.MessageBox;
using MainClient.Forms;
using Ninject;
using WCFCore.DataContracts;

namespace MainClient.UserControls.Users
{
    public partial class UsersEditView : ContentEditUserControlBase
    {
        #region fucking wforms
        public UsersEditView() : base() { }
        #endregion

        #region elem names
        private const string LoginTextBox = nameof(LoginTextBox);
        private const string PasswordTextBox = nameof(PasswordTextBox);
        private const string PositionComboBox = nameof(PositionComboBox);
        private const string ContactNumberMaskBox = nameof(ContactNumberMaskBox);
        private const string LastNameTextBox = nameof(LastNameTextBox);
        private const string SecondNameTextBox = nameof(SecondNameTextBox);
        private const string FirstNameTextBox = nameof(FirstNameTextBox);
        private const string ChangePasswordButton = nameof(ChangePasswordButton);
        #endregion
        #region header names
        private const string PositionHeader = "Должность";
        private const string ContactNumberHeader = "Контактный номер";
        private const string LastNameHeader = "Отчество";
        private const string SecondNameHeader = "Фамилия";
        private const string FirstNameHeader = "Имя";
        private const string PasswordHeader = "Пароль";
        private const string LoginHeader = "Логин";
        private const string ChangePasswordButtonText = "Изменить логин - пароль";
        private const string ContactNumberMask = "0-(000)-000-00-00";
        #endregion
        #region fields

        private readonly IMapperInject mapper;
        private readonly IMessageInject message;
        private readonly UsersView baseControl;
        private UserModel OldModel;
        private List<PositionModel> positions;

        #endregion
        #region ctor
        public UsersEditView(IKernel kernel, UsersView baseControl, UserModel model) : base(kernel, baseControl)
        {
            this.baseControl = baseControl;
            mapper = kernel.Get<IMapperInject>();
            message = kernel.Get<IMessageInject>();

            OldModel = model;
            positions = new List<PositionModel>();

            InitElements(model);
            UpdatePositionsSource(model);
            ResetModel(model);
            DeclineButton.Click += (s, e) => ResetModel(OldModel);
            SaveButton.Click += (s, e) => OnSaveMethod(true);
            SaveAndExit.Click += (s, e) => OnSaveMethod(false);
        }
        #endregion
        #region init heads
        private void InitElements(UserModel model)
        {
            int lastTabulation = 7;
            ContentPanel.CreateComboBoxWithLabel(PositionComboBox, PositionHeader, lastTabulation--);
            ContentPanel.CreateTextBoxWithLabel(ContactNumberMaskBox, ContactNumberHeader, lastTabulation--, ContactNumberMask);
            ContentPanel.CreateTextBoxWithLabel(LastNameTextBox, LastNameHeader, lastTabulation--);
            ContentPanel.CreateTextBoxWithLabel(SecondNameTextBox, SecondNameHeader, lastTabulation--);
            ContentPanel.CreateTextBoxWithLabel(FirstNameTextBox, FirstNameHeader, lastTabulation--);

            //login password for new
            if (model.IsNull())
            {
                ContentPanel.CreateTextBoxWithLabel(PasswordTextBox, PasswordHeader, lastTabulation--, passwordCharEnabled: true);
                ContentPanel.CreateTextBoxWithLabel(LoginTextBox, LoginHeader, lastTabulation--);
            }
            //and for old
            else if (!model.Login.Equals("admin"))
            {
                ContentPanel.CreateButtonWithLabel(ChangePasswordButton,
                                                   ChangePasswordButtonText,
                                                   lastTabulation--,
                                                   ChangeLoginPasswordClick);
            }
        }
        #endregion
        #region update positions
        private void UpdatePositionsSource(UserModel model)
        {
            ComboBox positionCombo = ContentPanel.GetFormControlFromPanel<ComboBox>(PositionComboBox);
            positionCombo.Items.Clear();
            if (!model.IsNull() && model.Login.Equals("admin"))
            {
                PositionModel position = mapper.Map<PositionDataContract, PositionModel>(
                    PositionsService.GetFirstPositionByName("Администратор").Result);
                positions.Add(position);
            }
            else
            {
                positions = mapper.Map<List<PositionDataContract>, List<PositionModel>>(
                    PositionsService.GetPositionsCollection().Result
                    .Where(p => !p.Name.Equals("Администратор")).ToList()
                    );
            }
            foreach (PositionModel item in positions)
            {
                positionCombo.Items.Add(item.Name);
            }
        }
        #endregion
        #region reset model
        private void ResetModel(UserModel model)
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
                        case LastNameTextBox:
                            textBox.Text = model.UserInfo?.LastName;
                            break;
                        case SecondNameTextBox:
                            textBox.Text = model.UserInfo?.SecondName;
                            break;
                        case FirstNameTextBox:
                            textBox.Text = model.UserInfo?.FirstName;
                            break;
                    }
                }
                if (item is ComboBox comboBox)
                {
                    comboBox.SelectedItem = model.Position.Name;
                }

                if (item is MaskedTextBox maskBox)
                {
                    maskBox.Text = model.UserInfo?.ContactNumber;
                }
            }
        }
        #endregion
        #region methods
        private void ChangeLoginPasswordClick(object sender, EventArgs e)
        {
            ChangePasswordForm change = new ChangePasswordForm(OldModel, message);
            change.ShowDialog();
            if (change.PasswordChanged)
            {
                OldModel.Password = change.User.Password;
                OnSaveMethod(true);
                message.ShowInfo("Пароль успешно изменен");
            }
            else
            {
                return;
            }
        }
        private void OnSaveMethod(bool IsAlive)
        {
            string fnameTemp = ContentPanel.GetFormControlFromPanel<TextBox>(FirstNameTextBox).Text;
            string snameTemp = ContentPanel.GetFormControlFromPanel<TextBox>(SecondNameTextBox).Text;
            string lnameTemp = ContentPanel.GetFormControlFromPanel<TextBox>(LastNameTextBox).Text;
            string contNumTemp = ContentPanel.GetFormControlFromPanel<MaskedTextBox>(ContactNumberMaskBox).Text;

            UserModel NewModel = new UserModel
            {
                UserInfo = new UserInfoModel()
                {
                    FirstName = fnameTemp,
                    SecondName = snameTemp,
                    LastName = lnameTemp,
                    ContactNumber = contNumTemp,
                }
            };

            if (OldModel.IsNull())
            {
                NewModel.UserInfo.ID = Guid.NewGuid();
            }
            else
            {
                NewModel.UserInfo.ID = OldModel.UserInfo.ID;
            }

            NewModel.Position = positions
                .FirstOrDefault(p => p.Name.Equals(ContentPanel.GetFormControlFromPanel<ComboBox>(PositionComboBox).Text));

            UserDataContract changes = new UserDataContract();
            int selectedModel = baseControl.Models.IndexOf(OldModel);

            if (OldModel.IsNull())
            {
                NewModel.ID = Guid.NewGuid();
                NewModel.Login = ContentPanel.GetFormControlFromPanel<TextBox>(LoginTextBox).Text;
                NewModel.Password = ContentPanel.GetFormControlFromPanel<TextBox>(PasswordTextBox).Text;

                changes = UsersService.InsertUser(mapper.Map<UserModel, UserDataContract>(NewModel)).Result;
                baseControl.Models.Add(mapper.Map<UserDataContract, UserModel>(changes));
            }
            else
            {
                NewModel.ID = baseControl.Models[selectedModel].ID;
                NewModel.Login = OldModel.Login;
                NewModel.Password = OldModel.Password;

                changes = UsersService.UpdateUser(mapper.Map<UserModel, UserDataContract>(NewModel)).Result;
                baseControl.Models[selectedModel] = mapper.Map<UserDataContract, UserModel>(changes);

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
