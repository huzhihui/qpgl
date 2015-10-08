using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 销售订单明细
    /// </summary>
    [DataContract]
    public class Sellorderdetail
    {
        /// <summary>
        /// 销售订单号 销售订单实体
        /// </summary>
        [DataMember]
        public Sellorder SELLORDER
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
        /// 销售预定序号
        /// </summary>
        [DataMember]
        public int SELLORDERDETAIL_NO
        {
            get;set;
        }
        /// <summary>
        /// 销售预定数
        /// </summary>
        [DataMember]
        public int SELLORDERDETAIL_AMOUNT
        {
            get;set;
        }
        /// <summary>
        /// 销售预定单价
        /// </summary>
        [DataMember]
        public double SELLORDERDETAIL_PRICE
        {
            get;set;
        }
        /// <summary>
        /// 销售预定扣率
        /// </summary>
        [DataMember]
        public double SELLORDERDETAIL_DISCOUNT
        {
            get;set;
        }
        /// <summary>
        /// 销售预定备注
        /// </summary>
        [DataMember]
        public string SELLORDERDETAIL_MEMO
        {
            get;set;
        }
        /// <summary>
        /// 销售预定批次
        /// </summary>
        [DataMember]
        public int SELLORDERDETAIL_BATCH
        {
            get;set;
        }
        /// <summary>
        /// 销售预定类型
        /// </summary>
        [DataMember]
        public int SELLORDERDETAIL_TYPE
        {
            get;set;
        }
    }
}
