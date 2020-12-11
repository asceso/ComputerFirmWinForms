using System;
using System.ComponentModel.DataAnnotations;

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

        [Display(Name = "Имя")]
        /// <summary>
        /// Имя клиента
        /// </summary>
        public string FirstName { get; set; }

        [Display(Name = "Фамилия")]
        /// <summary>
        /// Фамилия клиента
        /// </summary>
        public string SecondName { get; set; }

        [Display(Name = "Отчество")]
        /// <summary>
        /// Отчество клиента
        /// </summary>
        public string LastName { get; set; }

        [Display(Name = "Контактный номер")]
        /// <summary>
        /// Контактный номер
        /// </summary>
        public string ContactNumber { get; set; }

        [Display(Name = "Холодный контакт")]
        /// <summary>
        /// Холодный контакт
        /// </summary>
        public bool IsLead { get; set; }

        [Display(Name = "Удален в архив")]
        /// <summary>
        /// Удален в архив
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Возвращает полное имя клиента
        /// </summary>
        /// <returns>ФИО</returns>
        public string GetFullName() => $"{SecondName} {FirstName} {LastName}";

        public override string ToString() => GetFullName();
    }
}
