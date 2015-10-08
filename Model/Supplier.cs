using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// SUPPLIER
    /// </summary>
    [DataContract]
    public class Supplier
    {
        /// <summary>
        /// 供应商编号
        /// </summary>
        [DataMember]
        public string SUPPLIER_ID
        {
            get;set;
        }
        /// <summary>
        /// SuppliertypeID 商家类型实体
        /// </summary>
        [DataMember]
        public Suppliertype SUPPLIERTYPE
        {
            get;set;
        }
        /// <summary>
        /// 供应商名
        /// </summary>
        [DataMember]
        public string SUPPLIER_NAME
        {
            get;set;
        }
        /// <summary>
        /// 供应商_QQ
        /// </summary>
        [DataMember]
        public string SUPPLIER_QQ
        {
            get;set;
        }
        /// <summary>
        /// 供应商移动电话
        /// </summary>
        [DataMember]
        public string S_MOBILETEL
        {
            get;set;
        }
        /// <summary>
        /// 供应商办公室电话
        /// </summary>
        [DataMember]
        public string S_OFFICETEL
        {
            get;set;
        }
        /// <summary>
        /// 供应商地址
        /// </summary>
        [DataMember]
        public string S_ADDRESS
        {
            get;set;
        }
        /// <summary>
        /// 联系人
        /// </summary>
        [DataMember]
        public string S_CONTACT
        {
            get;set;
        }
        /// <summary>
        /// 传真
        /// </summary>
        [DataMember]
        public string S_FAX
        {
            get;set;
        }
        /// <summary>
        /// 邮政编码
        /// </summary>
        [DataMember]
        public string S_ZIP
        {
            get;set;
        }
        /// <summary>
        /// 电子邮箱
        /// </summary>
        [DataMember]
        public string S_EMAIL
        {
            get;set;
        }
        /// <summary>
        /// 货运地址
        /// </summary>
        [DataMember]
        public string S_GOODSADDRESS
        {
            get;set;
        }
        /// <summary>
        /// 开户行
        /// </summary>
        [DataMember]
        public string S_BANK
        {
            get;set;
        }
        /// <summary>
        /// 开户账号
        /// </summary>
        [DataMember]
        public string S_ACCOUNT
        {
            get;set;
        }
        /// <summary>
        /// 业务员
        /// </summary>
        [DataMember]
        public string S_AGENT
        {
            get;set;
        }
        /// <summary>
        /// 信誉额度
        /// </summary>
        [DataMember]
        public double S_CREDIBILITY
        {
            get;set;
        }
        /// <summary>
        /// 信誉账期
        /// </summary>
        [DataMember]
        public int S_CREDITDAY
        {
            get;set;
        }
        /// <summary>
        /// 供应商自编码
        /// </summary>
        [DataMember]
        public string USERENCODING
        {
            get;set;
        }
    }

}
