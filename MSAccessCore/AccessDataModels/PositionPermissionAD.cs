using System;

namespace MSAccessCore.AccessDataModels
{
    /// <summary>
    /// Разрешения должностей
    /// </summary>
    public class PositionPermissionAD
    {
        /// <summary>
        /// ИД записи
        /// </summary>
        public Guid ID { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public PositionAD Position { get; set; }

        /// <summary>
        /// Разрешение
        /// </summary>
        public PermissionAD Permission { get; set; }
    }
}
