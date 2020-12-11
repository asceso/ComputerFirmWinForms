using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ApplicationModels;
using ClientDataServices;
using CoreClient.ControlExtensions;
using CoreClient.StyleExtensions;
using InjectingCoreLibrary.MapperCore.ClientImplementation;
using InjectingCoreLibrary.MessagingCore.MessageBox;
using InjectingCoreLibrary.SettingsCore;
using Ninject;

namespace MainClient.UserControls.Requests.Repair
{
    public partial class RepairsView : UserControl
    {
        private readonly IMapperInject mapper;
        private readonly IMessageInject message;
        private readonly ISettingsInject settings;

        private List<RepairsRequestModel> models = new List<RepairsRequestModel>();

        private List<UserModel> users = new List<UserModel>();
        private List<RequestTypeModel> reqTypes = new List<RequestTypeModel>();

        private List<ClientModel> clients = new List<ClientModel>();
        public List<ClientModel> Clients
        {
            get => clients ?? (Clients = new List<ClientModel>());
            set => clients = value;
        }

        public RepairsView(IKernel kernel)
        {
            InitializeComponent();
            mapper = kernel.Get<IMapperInject>();
            message = kernel.Get<IMessageInject>();
            settings = kernel.Get<ISettingsInject>();
            BackColor = FormBrushes.WindowBackGroundColor;
            ForeColor = FormBrushes.WindowForegroundColor;
            ButtonsPanel.SetDefaultColorForChildren();
            MainLayoutTable.SetDefaultColorForChildren();
            CloseViewButton.Click += CloseViewButtonClick;
        }
        private void RepairsViewLoad(object sender, EventArgs e)
        {
            UpdateSources();
            UpdateReqNumber();
        }
        private void UpdateSources()
        {
            var settingsModel = settings.ReadConfig();

            var technPos = mapper.Map<PositionModel>(PositionsService.GetFirstPositionByName(settingsModel.TechnPositionName).Result);
            if (technPos.IsNull())
            {
                message.ShowInfo("Загрузка позиции техника завершена с ошибкой, имя должности должно совпадать с именем в настройках. Вкладка будет закрыта.");
                CloseViewButton.PerformClick();
                return;
            }

            models = mapper.Map<List<RepairsRequestModel>>(ReqRepairsService.GetRepairsRequestCollection().Result);
            repairsRequestModelBindingSource.DataSource = models;

            users = mapper.Map<List<UserModel>>(UsersService.GetUsersCollection().Result)
                .Where(u => u.Position.ID.Equals(technPos.ID)).ToList();

            var set = settingsModel.PositionToRequestTypeListDictionary[technPos.ID];
            reqTypes = mapper.Map<List<RequestTypeModel>>(RequestTypesService.GetRequestTypeCollection().Result)
                .Where(rt => set.Any(s => s.Equals(rt.ID))).ToList();

            clients = mapper.Map<List<ClientModel>>(ClientsService.GetClientsCollection().Result);

            userCB.Properties.Items.AddRange(users);
            reqTypeCB.Properties.Items.AddRange(reqTypes);
            clientModelBindingSource.DataSource = clients;
        }
        private void UpdateReqNumber()
        {
            var rn = Convert.ToInt32(models.OrderByDescending(m => m.RepairsNumber).FirstOrDefault().RepairsNumber) + 1;
            reqNumTE.Text = String.Format("{0:d5}", rn);
        }
        private void CloseViewButtonClick(object sender, EventArgs e) => Parent.Dispose();
        private void reqTypeCB_SelectedValueChanged(object sender, EventArgs e) => userCB.Enabled = !reqTypeCB.SelectedIndex.Equals(-1);
        private void CreateRequestButton_Click(object sender, EventArgs e)
        {
            if (reqNumTE.Text.IsNOE() || dateStartDE.Text.IsNOE() || dateTargetDE.Text.IsNOE() ||
                reqTypeCB.Text.IsNOE() || userCB.Text.IsNOE() || clientLUE.EditValue.IsNull())
            {
                message.ShowInfo("Не все поля были заполнены");
                return;
            }

            //создаем заявку
        }
    }
}
