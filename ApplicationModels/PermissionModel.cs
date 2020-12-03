using System;

namespace ApplicationModels
{
    /// <summary>
    /// Разрешения пользователей
    /// </summary>
    public class PermissionModel
    {
        /// <summary> 
        /// ИД записи
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Название разрешения
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
    }
}
