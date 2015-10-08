using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 销售合同
    /// </summary>
    [DataContract]
    public class Sellcontact
    {
        /// <summary>
        /// 销售合同号
        /// </summary>
        [DataMember]
        public string SALESCONTRACT_ID
        {
            get;set;
        }
        /// <summary>
        /// 客户编号 客户实体
        /// </summary>
        [DataMember]
        public Customer CUSTOMER
        {
            get;set;
        }
        /// <summary>
        /// customerTypeID 客户类型实体
        /// </summary>
        [DataMember]
        public Customertype CUSTOMERTYPE
        {
            get;set;
        }
        /// <summary>
        /// 零件编号 零件实体
        /// </summary>
        [DataMember]
        public Autoparts AUTOPARTS
        {
            get;set;
        }
        /// <summary>
        /// TpyeID 型号
        /// </summary>
        [DataMember]
        public Partstype PARTSTYPE
        {
            get;set;
        }
        /// <summary>
        /// 销售合同扣率
        /// </summary>
        [DataMember]
        public double SALESCONTRACT_DISCOUNT
        {
            get;set;
        }
        /// <summary>
        /// 销售合同销售价
        /// </summary>
        [DataMember]
        public double SALESCONTRACT_PRICE
        {
            get;set;
        }
        /// <summary>
        /// 销售合同有效期
        /// </summary>
        [DataMember]
        public DateTime SALESCONTRACT_VDATE
        {
            get;set;
        }
        /// <summary>
        /// 销售合同退货率
        /// </summary>
        [DataMember]
        public double SALESCONTRACT_RRATE
        {
            get;set;
        }
        /// <summary>
        /// 销售合同描述
        /// </summary>
        [DataMember]
        public string SALESCONTRACT_DES
        {
            get;set;
        }
        /// <summary>
        /// 销售包销合同售价
        /// </summary>
        [DataMember]
        public double SALESUNDERWRITE_PRIEC
        {
            get;set;
        }
        /// <summary>
        /// 销售包销合同扣率
        /// </summary>
        [DataMember]
        public double SALESUNDERWRITE_DISCOUNT
        {
            get;set;
        }
    }
}
