using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 积分兑换规则
    /// </summary>
    [DataContract]
    public class Vexchange_rule
    {
        /// <summary>
        /// 兑换规则标号
        /// </summary>
        [DataMember]
        public string EXCHANGE_RULE_ID
        {
            get;set;
        }
        /// <summary>
        /// 会员类型编号
        /// </summary>
        [DataMember]
        public Membertpye MEMBERTPYE
        {
            get;set;
        }
        /// <summary>
        /// 兑换规则名称
        /// </summary>
        [DataMember]
        public string EXCHANGE_RULE_NAME
        {
            get;set;
        }
        /// <summary>
        /// 开始积分
        /// </summary>
        [DataMember]
        public double BEGIN_VANTAGES
        {
            get;set;
        }
        /// <summary>
        /// 结束积分
        /// </summary>
        [DataMember]
        public double END_VANTAGES
        {
            get;set;
        }
        /// <summary>
        /// 商品编号
        /// </summary>
        [DataMember]
        public string GOODS_ID
        {
            get;set;
        }
        /// <summary>
        /// 每多少积分
        /// </summary>
        [DataMember]
        public double HOWMACHVANTAGES
        {
            get;set;
        }
        /// <summary>
        /// 兑换金额
        /// </summary>
        [DataMember]
        public double EXCHANGE_MONEY
        {
            get;set;
        }
        /// <summary>
        /// 积分兑换有效期
        /// </summary>
        [DataMember]
        public DateTime EXCHANGE_VALIDDATE
        {
            get;set;
        }
        /// <summary>
        /// 兑换规则是否启用
        /// </summary>
        [DataMember]
        public int EXCHANGE_ISSTART
        {
            get;set;
        }
    }
}
