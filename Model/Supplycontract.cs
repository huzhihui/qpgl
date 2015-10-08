using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 供应合同
    /// </summary>
    [DataContract]
    public class Supplycontract
    {
        /// <summary>
        /// 合同编号
        /// </summary>
        [DataMember]
        public string SUPPLYCONTRACTID
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
        /// 供应商编号
        /// </summary>
        [DataMember]
        public Supplier SUPPLIER
        {
            get;set;
        }
        /// <summary>
        /// 合同描述
        /// </summary>
        [DataMember]
        public string CONTRACTDESCRIPTION
        {
            get;set;
        }
        /// <summary>
        /// 有效期
        /// </summary>
        [DataMember]
        public DateTime VALIDITY
        {
            get;set;
        }
        /// <summary>
        /// 采购合同价
        /// </summary>
        [DataMember]
        public double PCONTRACT_PRICE
        {
            get;set;
        }
        /// <summary>
        /// 采购合同扣率
        /// </summary>
        [DataMember]
        public double PCONTRACT_DISCOUNT
        {
            get;set;
        }
        /// <summary>
        /// 采购退货率
        /// </summary>
        [DataMember]
        public double PRETURNRATE
        {
            get;set;
        }
        /// <summary>
        /// 采购包销合同价
        /// </summary>
        [DataMember]
        public double PUNDERWRITE_PRICE
        {
            get;set;
        }
        /// <summary>
        /// 采购包销合同扣率
        /// </summary>
        [DataMember]
        public double PUNDERWRITE_DISCOUNT
        {
            get;set;
        }
    }
}
