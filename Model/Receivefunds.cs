using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 收款单
    /// </summary>
    [DataContract]
    public class Receivefunds
    {
        /// <summary>
        /// 收款单号
        /// </summary>
        [DataMember]
        public string RECEIVEFUNDS_ID
        {
            get;set;
        }
        /// <summary>
        /// 客户实体
        /// </summary>
        [DataMember]
        public Customer CUSTOMER
        {
            get;set;
        }
        /// <summary>
        /// 收款日期
        /// </summary>
        [DataMember]
        public DateTime RECEIVEFUNDS_DATE
        {
            get;set;
        }
        /// <summary>
        /// 收款类型
        /// </summary>
        [DataMember]
        public string RECEIVEFUNDS_TYPE
        {
            get;set;
        }
        /// <summary>
        /// 收款凭证
        /// </summary>
        [DataMember]
        public string RECEIVEFUNDS_PZ
        {
            get;set;
        }
        /// <summary>
        /// 收款备注
        /// </summary>
        [DataMember]
        public string RECEIVEFUNDS_MEMO
        {
            get;set;
        }
        /// <summary>
        /// 收款金额
        /// </summary>
        public double RECEIVEFUNDS_MONEY
        {
            get;set;
        }
        /// <summary>
        /// 收款结算金额
        /// </summary>
        [DataMember]
        public double RECEIVEFUNDS_CLEARING
        {
            get;set;
        }
        /// <summary>
        /// 收款制单人
        /// </summary>
        [DataMember]
        public string RECEIVEFUNDS_MAKER
        {
            get;set;
        }
        /// <summary>
        /// 收款制单日期
        /// </summary>
        [DataMember]
        public DateTime RECEIVEFUNDS_MAKEDATE
        {
            get;set;
        }
        /// <summary>
        /// 收款复核人
        /// </summary>
        [DataMember]
        public string RECEIVEFUNDS_REVIEWER
        {
            get;set;
        }
        /// <summary>
        /// 收款复核日期
        /// </summary>
        [DataMember]
        public DateTime RECEIVEFUNDS_REVIEWDATE
        {
            get;set;
        }
        /// <summary>
        /// 收款复核记录
        /// </summary>
        [DataMember]
        public string RECEIVEFUNDS_REMARK
        {
            get;set;
        }
        /// <summary>
        /// 收款版本号
        /// </summary>
        [DataMember]
        public int RECEIVEFUNDS_VERSION
        {
            get;set;
        }
    }
}
