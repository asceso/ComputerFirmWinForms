using System;

namespace ApplicationModels
{
    /// <summary>
    /// Ращрешения должностей
    /// </summary>
    public class PositionPermissionModel
    {
        /// <summary>
        /// ИД записи
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public PositionModel Position { get; set; }

        /// <summary>
        /// Разрешение
        /// </summary>
        public PermissionModel Permission { get; set; }
    }
}
