using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 销退明细
    /// </summary>
    [DataContract]
    public class Sreturndetail
    {
        /// <summary>
        /// 销退单号 消退实体
        /// </summary>
        [DataMember]
        public Sellreturn SELLRETURN
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
        /// 销退序号
        /// </summary>
        [DataMember]
        public double SRETURNDETAIL_NO
        {
            get;set;
        }
        /// <summary>
        /// 销退数量
        /// </summary>
        [DataMember]
        public int SRETURNDETAIL_AMOUNT
        {
            get;set;
        }
        /// <summary>
        /// 销退单价
        /// </summary>
        [DataMember]
        public double SRETURNDETAIL_PRICE
        {
            get;set;
        }
        /// <summary>
        /// 销退扣率
        /// </summary>
        [DataMember]
        public double SRETURNDETAIL_DISCOU
        {
            get;set;
        }
        /// <summary>
        /// 销退成本
        /// </summary>
        [DataMember]
        public double SRETURNDETAIL_COST
        {
            get;set;
        }
        /// <summary>
        /// 销退批次
        /// </summary>
        [DataMember]
        public int SRETURNDETAIL_BATCH
        {
            get;set;
        }
        /// <summary>
        /// 销退明细备注
        /// </summary>
        [DataMember]
        public string SRETURNDETAIL_MEMO
        {
            get;set;
        }
        /// <summary>
        /// 销退明细结算
        /// </summary>
        [DataMember]
        public double SRETURNDETAIL_CLEARING
        {
            get;set;
        }
        /// <summary>
        /// 销退复核记录
        /// </summary>
        [DataMember]
        public string SRETURNDETAIL_REMARK
        {
            get;set;
        }

    }
}
