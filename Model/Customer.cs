using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 客户
    /// </summary>
    [DataContract]
    public class Customer
    {
        /// <summary>
        /// 客户编号
        /// </summary>
        [DataMember]
        public string CUSTOMER_ID
        {
            get; set;
        }

        /// <summary>
        /// 客户类型编号
        /// </summary>
        [DataMember]
        public Customer CUSTOMERTYPE
        {
            get; set;
        }

        /// <summary>
        /// 会员编号
        /// </summary>
        [DataMember]
        public Member MEMBER
        {
            get; set;
        }

        /// <summary>
        /// 客户名
        /// </summary>
        [DataMember]
        public string CUSTOMER_NAME
        {
            get; set;
        }

        /// <summary>
        /// 客户QQ
        /// </summary>
        [DataMember]
        public string C_QQ
        {
            get; set;
        }

        /// <summary>
        /// 客户电话
        /// </summary>
        [DataMember]
        public string C_MOBILETEL
        {
            get; set;
        }

        /// <summary>
        /// 客户办公电话
        /// </summary>
        [DataMember]
        public string C_OFFICETEL
        {
            get; set;
        }

        /// <summary>
        /// 客户联系
        /// </summary>
        [DataMember]
        public string C_CONTACT
        {
            get; set;
        }

        /// <summary>
        /// 客户传真
        /// </summary>
        [DataMember]
        public string C_FAX
        {
            get; set;
        }

        /// <summary>
        /// 客户邮编
        /// </summary>
        [DataMember]
        public string C_ZIP
        {
            get; set;
        }

        /// <summary>
        /// 客户地址
        /// </summary>
        [DataMember]
        public string C_ADDRESS
        {
            get; set;
        }

        /// <summary>
        /// 客户邮箱
        /// </summary>
        [DataMember]
        public string C_EMAIL
        {
            get; set;
        }

        /// <summary>
        /// 客户送货地址
        /// </summary>
        [DataMember]
        public string C_GOODSADDRESS
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string C_TAXID
        {
            get; set;
        }

        /// <summary>
        /// 客户银行
        /// </summary>
        [DataMember]
        public string C_BANK
        {
            get; set;
        }

        /// <summary>
        /// 客户银行账号
        /// </summary>
        [DataMember]
        public string C_ACCOUNT
        {
            get; set;
        }

        /// <summary>
        /// 客户联系人
        /// </summary>
        [DataMember]
        public string C_AGENT
        {
            get; set;
        }

        /// <summary>
        /// 客户可靠性
        /// </summary>
        [DataMember]
        public double C_CREDIBILITY
        {
            get; set;
        }

        /// <summary>
        /// 客户最近购物时间
        /// </summary>
        [DataMember]
        public int C_CREDITDAY
        {
            get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string C_ZBM
        {
            get; set;
        }

        /// <summary>
        /// 是否停止客户
        /// </summary>
        [DataMember]
        public int C_ISSTOP
        {
            get; set;
        }
    }
}
