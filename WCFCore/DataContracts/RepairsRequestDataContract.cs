using System.Runtime.Serialization;

namespace WCFCore.DataContracts
{
    [DataContract]
    /// <summary>
    /// Заявки на ремонт
    /// </summary>
    public class RepairsRequestDataContract : BaseRequestDataContract
    {
        [DataMember]
        /// <summary>
        /// Номер заявки на ремонт
        /// </summary>
        public string RepairsNumber { get; set; }
    }
}
