using System.ComponentModel.DataAnnotations;

namespace ApplicationModels
{
    /// <summary>
    /// Заявки на ремонт
    /// </summary>
    public class RepairsRequestModel : BaseRequestModel
    {
        [Display(Name = "Номер заявки")]
        /// <summary>
        /// Номер заявки на ремонт
        /// </summary>
        public string RepairsNumber { get; set; }
    }
}
