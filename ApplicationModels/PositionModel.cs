using System;

namespace ApplicationModels
{
    /// <summary>
    /// Должности
    /// </summary>
    public class PositionModel
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

        public override string ToString() => Name;
    }
}
