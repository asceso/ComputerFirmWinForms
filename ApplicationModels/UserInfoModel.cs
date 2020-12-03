using System;

namespace ApplicationModels
{
    /// <summary>
    /// Доп информация сотрудника
    /// </summary>
    public class UserInfoModel
    {
        /// <summary>
        /// ИД Записи
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string SecondName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Контактный номер
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Возвращает полное имя клиента
        /// </summary>
        /// <returns>ФИО</returns>
        public string GetFullName() => $"{SecondName} {FirstName} {LastName}";
    }
}
