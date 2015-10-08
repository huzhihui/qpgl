using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 供应商账务往来
    /// </summary>
    [DataContract]
    public class Saccountsdealings
    {
        /// <summary>
        /// 付款实体
        /// </summary>
        [DataMember]
        public Payment PAYMENT
        {
            get;set;
        }
        /// <summary>
        /// 业务单号
        /// </summary>
        [DataMember]
        public string TRADINGCARDID
        {
            get;set;
        }
        /// <summary>
        /// 结算金额
        /// </summary>
        [DataMember]
        public double SETTLEMENTAMOUNT
        {
            get;set;
        }
        /// <summary>
        /// 结算日期
        /// </summary>
        [DataMember]
        public DateTime SETTLEMENTDATE
        {
            get;set;
        }
        /// <summary>
        /// 结算人
        /// </summary>
        [DataMember]
        public string SETTLEMENTAMOUNT_MAKER
        {
            get;set;
        }
    }
}
