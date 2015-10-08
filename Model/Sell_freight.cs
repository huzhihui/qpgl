using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 销售货运单
    /// </summary>
    [DataContract]
    public class Sell_freight
    {
        /// <summary>
        /// 销售货运编号
        /// </summary>
        [DataMember]
        public string SELL_FREIGHT_ID
        {
            get;set;
        }
        /// <summary>
        /// 网点实体
        /// </summary>
        [DataMember]
        public Freightpoint FREIGHTPOINT
        {
            get;set;
        }
        /// <summary>
        /// 客户实体
        /// </summary>
        [DataMember]
        public Customer CUSTOMER
        {
            get;set;
        }
        /// <summary>
        /// 销售货运日期
        /// </summary>
        [DataMember]
        public DateTime SELL_FREIGHT_DATE
        {
            get;set;
        }
        /// <summary>
        /// 销售货运发货人
        /// </summary>
        [DataMember]
        public string SELL_FREIGHT_SENDER
        {
            get;set;
        }
        /// <summary>
        /// 销售货运备注
        /// </summary>
        [DataMember]
        public string SELL_FREIGHT_MEMO
        {
            get;set;
        }
        /// <summary>
        /// 销售货运总运费
        /// </summary>
        [DataMember]
        public double SELL_FREIGHT_TOTALFARE
        {
            get;set;
        }
        /// <summary>
        /// 销售货运做单人
        /// </summary>
        [DataMember]
        public string SELL_FREIGHT_MAKER
        {
            get;set;
        }
        /// <summary>
        /// 销售货运做单日期
        /// </summary>
        [DataMember]
        public DateTime SELL_FREIGHT_MAKEDATE
        {
            get;set;
        }
    }
}
