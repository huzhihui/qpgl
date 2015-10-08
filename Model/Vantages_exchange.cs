using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 积分兑换
    /// </summary>
    [DataContract]
    public class Vantages_exchange
    {
        /// <summary>
        /// 积分兑换编号
        /// </summary>
        [DataMember]
        public string VANTAGES_EXCHANGE_ID
        {
            get;set;
        }
        /// <summary>
        /// 会员编号
        /// </summary>
        [DataMember]
        public Member MEMBER
        {
            get;set;
        }
        /// <summary>
        /// 积分兑换的日期
        /// </summary>
        [DataMember]
        public DateTime VANTAGES_EXCHANGE_DATE
        {
            get;set;
        }
        /// <summary>
        /// 积分兑换的商品
        /// </summary>
        [DataMember]
        public string VANTAGES_EXCHANGE_GOODS
        {
            get;set;
        }
        /// <summary>
        /// 积分兑换的金额
        /// </summary>
        [DataMember]
        public double VANTAGES_EXCHANGE_MONEY
        {
            get;set;
        }
        /// <summary>
        /// 所用积分
        /// </summary>
        [DataMember]
        public double USEVANTAGES
        {
            get;set;
        }
    }
}
