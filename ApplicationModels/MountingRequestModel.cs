namespace ApplicationModels
{
    /// <summary>
    /// Заявки на монтаж ЛВС
    /// </summary>
    public class MountingRequestModel : BaseRequestModel
    {
        /// <summary>
        /// Номер заявки на монтаж
        /// </summary>
        public string MountingNumber { get; set; }
    }
}
