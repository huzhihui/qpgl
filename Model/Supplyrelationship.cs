using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 供应关系
    /// </summary>
    [DataContract]
    public class Supplyrelationship
    {
        /// <summary>
        /// 供应商编号
        /// </summary>
        [DataMember]
        public Supplier SUPPLIER
        {
            get;set;
        }
        /// <summary>
        /// 零件编号
        /// </summary>
        [DataMember]
        public Autoparts AUTO_PARTS
        {
            get;set;
        }
        /// <summary>
        /// 进价
        /// </summary>
        [DataMember]
        public double PUR_PRICE
        {
            get;set;
        }
    }
}
