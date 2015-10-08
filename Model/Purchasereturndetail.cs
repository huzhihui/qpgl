using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 采退明细
    /// </summary>
    [DataContract]
    public class Purchasereturndetail
    {
        /// <summary>
        /// 采退实体
        /// </summary>
        [DataMember]
        public Purchasereturns PURCHASERETURNS
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
        /// 采退序号
        /// </summary>
        [DataMember]
        public int PRETURN_NO
        {
            get;set;
        }
        /// <summary>
        /// 采退数量
        /// </summary>
        [DataMember]
        public int PRETURN_AMOUNT
        {
            get;set;
        }
        /// <summary>
        /// 采退单价
        /// </summary>
        [DataMember]
        public double PRETURN_PRICE
        {
            get;set;
        }
        /// <summary>
        /// 采退扣率
        /// </summary>
        [DataMember]
        public double PRETURN_DISCOUNT
        {
            get;set;
        }
        /// <summary>
        /// 采退成本
        /// </summary>
        [DataMember]
        public double PRETURN_COST
        {
            get;set;
        }
        /// <summary>
        /// 采退批次
        /// </summary>
        [DataMember]
        public int PRETURN_BITCH
        {
            get;set;
        }
        /// <summary>
        /// 采退明细备注
        /// </summary>
        [DataMember]
        public string PRETURN_DETAILMEMO
        {
            get;set;
        }
        /// <summary>
        /// 采退明细结算
        /// </summary>
        [DataMember]
        public double PRETURN_DETAILCLEARING
        {
            get;set;
        }
        /// <summary>
        /// 采退复核记录
        /// </summary>
        [DataMember]
        public string PRETURN_REVIEWRECORD
        {
            get;set;
        }
    }
}
