using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Forms;
using ClientDataServices;
using CoreClient.ControlExtensions;
using CoreClient.ShellModels;
using InjectingCoreLibrary.MapperCore.ClientImplementation;
using InjectingCoreLibrary.MessagingCore.AskBox;
using InjectingCoreLibrary.MessagingCore.MessageBox;
using Ninject;
using PermissionsManager;
using WCFCore.DataContracts;

namespace MainClient.UserControls.Users
{
    public partial class UsersView : ContentUserControlBase
    {
        #region fucking wforms
        public UsersView() : base() { }
        #endregion

        #region Fields

        private readonly IMapperInject mapper;
        private ObservableCollection<UserModel> models;

        #endregion
        #region Props

        public ObservableCollection<UserModel> Models
        {
            get => models ??= new ObservableCollection<UserModel>();
            set => models = value;
        }

        #endregion
        #region Ctor

        public UsersView(IKernel kernel) : base(kernel)
        {
            CollectionView.MultiSelect = false;
            mapper = kernel.Get<IMapperInject>();
            InitHeaders();
            UpdateCollection(true);

            AddButton.Click += AddButtonClick;
            EditButton.Click += EditButtonClick;
            CollectionView.MouseDoubleClick += CollectionViewMouseDoubleClick;
            DeleteButton.Click += DeleteButtonClickAsync;

            AddButton.SetVisibleByPermissionStatus(kernel.Get<IPermissionInject>().IsHasPermission("UsersIns"));
            EditButton.SetVisibleByPermissionStatus(kernel.Get<IPermissionInject>().IsHasPermission("UsersUpd"));
            DeleteButton.SetVisibleByPermissionStatus(kernel.Get<IPermissionInject>().IsHasPermission("UsersDel"));
            //todo: Допилить ивент аггрегатор
        }

        #endregion
        #region Update collection

        private void InitHeaders()
        {
            CollectionView.Columns.Add("Логин", 100);
            CollectionView.Columns.Add("Имя", 100);
            CollectionView.Columns.Add("Фамилия", 100);
            CollectionView.Columns.Add("Отчество", 100);
            CollectionView.Columns.Add("Контактный номер", 150);
            CollectionView.Columns.Add("Должность", 150);
        }
        internal void UpdateCollection(bool modify)
        {
            if (!modify)
            {
                return;
            }

            IEnumerable<UserDataContract> dataUsers = (UsersService.GetUsersCollection().Result);
            IEnumerable<UserModel> users = kernel.Get<IMapperInject>().Map<IEnumerable<UserDataContract>, IEnumerable<UserModel>>(dataUsers);
            Models = new ObservableCollection<UserModel>();
            Models.CollectionChanged += ModelsCollectionChanged;
            foreach (UserModel user in users)
            {
                Models.Add(user);
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
                UserModel RemovedModel = Models[CollectionView.SelectedIndices[0]];
                int removed = await UsersService.DeleteUser(mapper.Map<UserModel, UserDataContract>(RemovedModel));
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
            Controls.Add(new UsersEditView(kernel, this, null));
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

            Controls.Add(new UsersEditView(kernel, this, Models[CollectionView.SelectedIndices[0]]));
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
                        if (e.NewItems[0] is UserModel user)
                        {
                            string[] collectionItem = new string[]
                            {
                                user.Login,
                                string.IsNullOrEmpty(user.UserInfo?.FirstName)?"-":user.UserInfo?.FirstName,
                                string.IsNullOrEmpty(user.UserInfo?.SecondName)?"-":user.UserInfo?.SecondName,
                                string.IsNullOrEmpty(user.UserInfo?.LastName)?"-":user.UserInfo?.LastName,
                                string.IsNullOrEmpty(user.UserInfo?.ContactNumber)?"-":user.UserInfo?.ContactNumber,
                                user.Position?.Name
                            };
                            CollectionView.Items.Add(new ListViewItem(collectionItem));
                        }
                    }
                    break;
                case NotifyCollectionChangedAction.Replace:
                    {
                        int insertIndex = -1;
                        if (e.OldItems[0] is UserModel oldUser)
                        {
                            insertIndex = Models.IndexOf(Models.FirstOrDefault(u => u.ID.Equals(oldUser.ID)));
                            CollectionView.Items.RemoveAt(insertIndex);
                        }
                        if (e.NewItems[0] is UserModel user)
                        {
                            string[] collectionItem = new string[]
                            {
                                user.Login,
                                string.IsNullOrEmpty(user.UserInfo?.FirstName)?"-":user.UserInfo?.FirstName,
                                string.IsNullOrEmpty(user.UserInfo?.SecondName)?"-":user.UserInfo?.SecondName,
                                string.IsNullOrEmpty(user.UserInfo?.LastName)?"-":user.UserInfo?.LastName,
                                string.IsNullOrEmpty(user.UserInfo?.ContactNumber)?"-":user.UserInfo?.ContactNumber,
                                user.Position?.Name
                            };
                            CollectionView.Items.Insert(insertIndex, new ListViewItem(collectionItem));
                        }
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    {
                        int removeIndex = e.OldStartingIndex;
                        if (e.OldItems[0] is UserModel oldUser)
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
