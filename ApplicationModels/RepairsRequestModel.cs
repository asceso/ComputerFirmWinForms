namespace ApplicationModels
{
    /// <summary>
    /// Заявки на ремонт
    /// </summary>
    public class RepairsRequestModel : BaseRequestModel
    {
        /// <summary>
        /// Номер заявки на ремонт
        /// </summary>
        public string RepairsNumber { get; set; }
    }
}
