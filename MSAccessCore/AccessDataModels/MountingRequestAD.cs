namespace MSAccessCore.AccessDataModels
{
    /// <summary>
    /// Заявки на монтаж ЛВС
    /// </summary>
    public class MountingRequestAD : BaseRequestAD
    {
        /// <summary>
        /// Номер заявки на монтаж
        /// </summary>
        public string MountingNumber { get; set; }
    }
}
