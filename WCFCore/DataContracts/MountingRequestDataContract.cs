using System.Runtime.Serialization;

namespace WCFCore.DataContracts
{
    [DataContract]
    /// <summary>
    /// Заявки на монтаж ЛВС
    /// </summary>
    public class MountingRequestDataContract : BaseRequestDataContract
    {
        [DataMember]
        /// <summary>
        /// Номер заявки на монтаж
        /// </summary>
        public string MountingNumber { get; set; }
    }
}
