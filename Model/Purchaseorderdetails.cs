using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    [DataContract]
    public class Purchaseorderdetails
    {
        /// <summary>
        /// 订单实体
        /// </summary>
        [DataMember]
        public Purchaseorder PURCHASEORDER
        {
            get;set;
        }
        /// <summary>
        /// 零件实体
        /// </summary>
        [DataMember]
        public Autoparts AUTOPARTS
        {
            get;set;
        }
        /// <summary>
        /// 预定序号
        /// </summary>
        [DataMember]
        public int ORDER_NO
        {
            get;set;
        }
        /// <summary>
        /// 预定数量
        /// </summary>
        [DataMember]
        public int ORDER_AMOUNT
        {
            get;set;
        }
        /// <summary>
        /// 预定单价
        /// </summary>
        [DataMember]
        public double ORDER_PRICE
        {
            get;set;
        }
        /// <summary>
        /// 预定扣率
        /// </summary>
        [DataMember]
        public double ORDER_DISCOUNT
        {
            get;set;
        }
        /// <summary>
        /// 预定备注
        /// </summary>
        [DataMember]
        public string ORDER_MEMO
        {
            get;set;
        }
        /// <summary>
        /// 预定方式
        /// </summary>
        [DataMember]
        public int ORDER_TYPE
        {
            get;set;
        }
    }
}
