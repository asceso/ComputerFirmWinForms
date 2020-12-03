using System;

namespace MSAccessCore.AccessDataModels
{
    /// <summary>
    /// Должности
    /// </summary>
    public class PositionAD
    {
        /// <summary> 
        /// ИД записи
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
    }
}
