using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 公司
    /// </summary>
    [DataContract]
    public class Company
    {
        /// <summary>
        /// 公司名称
        /// </summary>
        [DataMember]
        public string COMPANY_NAME
        {
            get; set;
        }

        /// <summary>
        /// 公司地址
        /// </summary>
        [DataMember]
        public string COMPANY_ADDRESS
        {
            get; set;
        }

        /// <summary>
        /// 公司电话
        /// </summary>
        [DataMember]
        public string COMPANY_TEL
        {
            get; set;
        }

        /// <summary>
        /// 公司联系人
        /// </summary>
        [DataMember]
        public string COMPANY_AGENT
        {
            get; set;
        }

        /// <summary>
        /// 公司传真
        /// </summary>
        [DataMember]
        public string COMPANY_FAX
        {
            get; set;
        }

        /// <summary>
        /// 开户银行
        /// </summary>
        [DataMember]
        public string COMPANY_BANK
        {
            get; set;
        }

        /// <summary>
        /// 账户名
        /// </summary>
        [DataMember]
        public string COMPANY_ACCOUNTNAME
        {
            get; set;
        }

        /// <summary>
        /// 账号
        /// </summary>
        [DataMember]
        public string COMPANY_ACCOUNT
        {
            get; set;
        }

        /// <summary>
        /// 公司描述
        /// </summary>
        [DataMember]
        public string COMPANY_DISC
        {
            get; set;
        }
    }
}
