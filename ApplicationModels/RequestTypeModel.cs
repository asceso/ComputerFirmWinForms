using System;

namespace ApplicationModels
{
    /// <summary>
    /// Типы заявок
    /// </summary>
    public class RequestTypeModel
    {
        /// <summary>
        /// ИД
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string RequestName { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
    }
}
