using System;

namespace ApplicationModels
{
    /// <summary>
    /// Сотрудники
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// ИД записи
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Логин
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Пароль
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Доп информация сотрудника
        /// </summary>
        public UserInfoModel UserInfo { get; set; }

        /// <summary>
        ///  Должность
        /// </summary>
        public PositionModel Position { get; set; }
    }
}
