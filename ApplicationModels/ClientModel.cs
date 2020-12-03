using System;

namespace ApplicationModels
{
    /// <summary>
    /// Клиент
    /// </summary>
    public class ClientModel
    {
        /// <summary>
        /// ИД записи клиента
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Имя клиента
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Фамилия клиента
        /// </summary>
        public string SecondName { get; set; }

        /// <summary>
        /// Отчество клиента
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Контактный номер
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Холодный контакт
        /// </summary>
        public bool IsLead { get; set; }

        /// <summary>
        /// Удален в архив
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Возвращает полное имя клиента
        /// </summary>
        /// <returns>ФИО</returns>
        public string GetFullName() => $"{SecondName} {FirstName} {LastName}";
    }
}
