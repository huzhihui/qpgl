using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 销售明细
    /// </summary>
    [DataContract]
    public class Selldetail
    {
        /// <summary>
        /// 销售单号 销售实体
        /// </summary>
        [DataMember]
        public Sell SELL
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
        /// 销售序号
        /// </summary>
        [DataMember]
        public int SELLDETAIL_NO
        {
            get;set;
        }
        /// <summary>
        /// 销售数量
        /// </summary>
        [DataMember]
        public int SELLDETAIL_AMOUNT
        {
            get;set;
        }
        /// <summary>
        /// 销售单价
        /// </summary>
        [DataMember]
        public double SELLDETAIL_PRICE
        {
            get;set;
        }
        /// <summary>
        /// 销售扣率
        /// </summary>
        [DataMember]
        public double SELLDETAIL_DISCOUNT
        {
            get;set;
        }
        /// <summary>
        /// 销售成本
        /// </summary>
        [DataMember]
        public double SELLDETAIL_COST
        {
            get;set;
        }
        /// <summary>
        /// 销售批次
        /// </summary>
        [DataMember]
        public int SELLDETAIL_BATCH
        {
            get;set;
        }
        /// <summary>
        /// 销售明细备注
        /// </summary>
        [DataMember]
        public string SELLDETAIL_MEMO
        {
            get;set;
        }
        /// <summary>
        /// 销售明细结算
        /// </summary>
        [DataMember]
        public double SELLDETAIL_CLEARING
        {
            get;set;
        }
        /// <summary>
        /// 销售复核记录
        /// </summary>
        [DataMember]
        public string SELLDETAIL_REMARK
        {
            get;set;
        }
        /// <summary>
        /// 防伪条码
        /// </summary>
        [DataMember]
        public string SELLDETAIL_BARCODE
        {
            get;set;
        }
        /// <summary>
        /// 销售退货期限
        /// </summary>
        [DataMember]
        public DateTime SELLDETAIL_RDEADLINE
        {
            get;set;
        }
        /// <summary>
        /// 销售出货数
        /// </summary>
        [DataMember]
        public int SELLDETAIL_DELIVERYNUMBER
        {
            get;set;
        }
    }
}
