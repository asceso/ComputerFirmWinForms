using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicationModels
{
    /// <summary>
    /// Раpрешения должностей
    /// </summary>
    public class PositionPermissionModel
    {
        /// <summary>
        /// ИД записи
        /// </summary>
        public Guid ID { get; set; }

        [Display(Name = "Должность")]
        /// <summary>
        /// Должность
        /// </summary>
        public PositionModel Position { get; set; }

        [Display(Name = "Разрешение")]
        /// <summary>
        /// Разрешение
        /// </summary>
        public PermissionModel Permission { get; set; }

        public override string ToString() => $"Должность: {Position.Name} === Разрешение: {Permission.Description}";
    }
}
