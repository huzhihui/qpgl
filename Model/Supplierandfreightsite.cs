using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 供应商货运网点描述
    /// </summary>
    [DataContract]
    public class Supplierandfreightsite
    {
        /// <summary>
        /// 网点编号
        /// </summary>
        [DataMember]
        public Freightpoint FREIGHTPOINT
        {
            get;set;
        }
        /// <summary>
        /// 供应商编号
        /// </summary>
        [DataMember]
        public Supplier SUPPLIER
        {
            get;set;
        }
        /// <summary>
        /// 供应商网点优先级
        /// </summary>
        [DataMember]
        public int SFREIGHTPOINT_PRIORITY
        {
            get;set;
        }
    }
}
