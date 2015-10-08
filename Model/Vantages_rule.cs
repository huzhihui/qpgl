using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 积分规则
    /// </summary>
    [DataContract]
    public class Vantages_rule
    {
        /// <summary>
        /// 积分规则编号
        /// </summary>
        [DataMember]
        public string VANTAGES_RULE_ID
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
        /// 积分规则名称
        /// </summary>
        [DataMember]
        public string VANTAGES_RULE_NAME
        {
            get;set;
        }
        /// <summary>
        /// 每金额
        /// </summary>
        [DataMember]
        public double PER_MONEY
        {
            get;set;
        }
        /// <summary>
        /// 换积分
        /// </summary>
        [DataMember]
        public double TO_VANTAGES
        {
            get;set;
        }
        /// <summary>
        /// 单笔交易量
        /// </summary>
        [DataMember]
        public double TOTAL_MONEY
        {
            get;set;
        }
        /// <summary>
        /// 折算积分
        /// </summary>
        [DataMember]
        public double GET_VANTAGES
        {
            get;set;
        }
        /// <summary>
        /// 积分规则有效期
        /// </summary>
        [DataMember]
        public DateTime VANTAGES_RULE_VALIDDATE
        {
            get;set;
        }
        /// <summary>
        /// 积分规则优先级
        /// </summary>
        [DataMember]
        public int VANTAGES_RULE_PRIORITY
        {
            get;set;
        }
        /// <summary>
        /// 积分规则是否启用
        /// </summary>
        [DataMember]
        public int VANTAGES_RULE_ACTIVATED
        {
            get;set;
        }
    }
}
