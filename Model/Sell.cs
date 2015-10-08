using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 销售单
    /// </summary>
    [DataContract]
    public class Sell
    {
        /// <summary>
        /// 销售单号
        /// </summary>
        [DataMember]
        public string SELL_ID
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
        /// 仓库实体
        /// </summary>
        [DataMember]
        public Warehouse WAREHOUSE
        {
            get;set;
        }
        /// <summary>
        /// 销售日期
        /// </summary>
        [DataMember]
        public DateTime SELL_DATE
        {
            get;set;
        }
        /// <summary>
        /// 销售总数量
        /// </summary>
        [DataMember]
        public int SELL_TOTALAMOUNT
        {
            get;set;
        }
        /// <summary>
        /// 销售总金额
        /// </summary>
        [DataMember]
        public double SELL_TOTALMENEY
        {
            get;set;
        }
        /// <summary>
        /// 销售备注
        /// </summary>
        [DataMember]
        public string SELL_MEMO
        {
            get;set;
        }
        /// <summary>
        /// 销售结算总金额
        /// </summary>
        [DataMember]
        public double SELL_TOTALCLEARING
        {
            get;set;
        }
        /// <summary>
        /// 销售制单人
        /// </summary>
        [DataMember]
        public string SELL_MAKER
        {
            get;set;
        }
        /// <summary>
        /// 销售制单日期
        /// </summary>
        [DataMember]
        public DateTime SELL_MAKEDATE
        {
            get;set;
        }
        /// <summary>
        /// 销售复核人
        /// </summary>
        [DataMember]
        public string SELL_REVIEWER
        {
            get;set;
        }
        /// <summary>
        /// 销售复核日期
        /// </summary>
        [DataMember]
        public DateTime SELL_REVIEWDATE
        {
            get;set;
        }
        /// <summary>
        /// 销售单打印次数
        /// </summary>
        [DataMember]
        public int SELL_PRINTTIME
        {
            get;set;
        }
        /// <summary>
        /// 销售单版本
        /// </summary>
        [DataMember]
        public int SELL_VERSION
        {
            get;set;
        }
    }
}
