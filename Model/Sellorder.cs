using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 销售订单
    /// </summary>
    [DataContract]
    public class Sellorder
    {
        /// <summary>
        /// 销售订单号
        /// </summary>
        [DataMember]
        public string SELLORDER_ID
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
        /// 销售订单备注
        /// </summary>
        [DataMember]
        public string SELLORDER_MEMO
        {
            get;set;
        }
        /// <summary>
        /// 销售订单总数量
        /// </summary>
        [DataMember]
        public int SELLORDER_TOTALAMOUNT
        {
            get;set;
        }
        /// <summary>
        /// 销售订单总金额
        /// </summary>
        [DataMember]
        public double SELLORDER_TOTALMONEY
        {
            get;set;
        }
        /// <summary>
        /// 销售订单制单人
        /// </summary>
        [DataMember]
        public string SELLORDER_MAKER
        {
            get;set;
        }
        /// <summary>
        /// 销售订单制单日期
        /// </summary>
        [DataMember]
        public DateTime SELLORDER_MAKEDATE
        {
            get;set;
        }
        /// <summary>
        /// 销售订单复核人
        /// </summary>
        [DataMember]
        public string SELLORDER_REVIEWER
        {
            get;set;
        }
        /// <summary>
        /// 销售订单复核日期
        /// </summary>
        [DataMember]
        public DateTime SELLORDER_REVIEWDATE
        {
            get;set;
        }
    }
}
