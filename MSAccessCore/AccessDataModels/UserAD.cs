using System;

namespace MSAccessCore.AccessDataModels
{
    /// <summary>
    /// Сотрудники
    /// </summary>
    public class UserAD
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
        public UserInfoAD UserInfo { get; set; }

        /// <summary>
        ///  Должность
        /// </summary>
        public PositionAD Position { get; set; }
    }
}
