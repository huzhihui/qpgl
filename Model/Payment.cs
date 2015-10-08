using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 配件用途分类
    /// </summary>
    [DataContract]
    public class Payment
    {
        /// <summary>
        ///付款单号
        /// </summary>
        [DataMember]
        public string PAYMENT_ID
        {
            get; set;
        }

        /// <summary>
        ///供应商编号
        /// </summary>
        [DataMember]
        public Supplier SUPPLIER
        {
            get; set;
        }

        /// <summary>
        ///付款日期
        /// </summary>
        [DataMember]
        public DateTime PAYMENT_DATE
        {
            get; set;
        }

        /// <summary>
        ///付款类型
        /// </summary>
        [DataMember]
        public string PAYMENT_TYPE
        {
            get; set;
        }

        /// <summary>
        ///付款凭证
        /// </summary>
        [DataMember]
        public string PAYMENT_PROOF
        {
            get; set;
        }

        /// <summary>
        ///付款备注
        /// </summary>
        [DataMember]
        public string PAYMENT_MEMO
        {
            get; set;
        }

        /// <summary>
        ///付款金额
        /// </summary>
        [DataMember]
        public double PAYMENT_MONEY
        {
            get; set;
        }

        /// <summary>
        ///付款结算金额
        /// </summary>
        [DataMember]
        public double PAYMENT_CLEARING
        {
            get; set;
        }

        /// <summary>
        ///付款制单人
        /// </summary>
        [DataMember]
        public string PAYMENT_MAKER
        {
            get; set;
        }

        /// <summary>
        ///付款制单日期
        /// </summary>
        [DataMember]
        public DateTime PAYMENT_MAKEDATE
        {
            get; set;
        }

        /// <summary>
        ///付款复核人
        /// </summary>
        [DataMember]
        public string PAYMENT_REVIEWER
        {
            get; set;
        }

        /// <summary>
        ///付款复核日期
        /// </summary>
        [DataMember]
        public DateTime PAYMENT_REVIEWDATE
        {
            get; set;
        }

        /// <summary>
        ///付款复核记录
        /// </summary>
        [DataMember]
        public string PAYMENT_REMARK
        {
            get; set;
        }

        /// <summary>
        ///付款版本号
        /// </summary>
        [DataMember]
        public int PAYMENT_VERSION
        {
            get; set;
        }
    }
}
