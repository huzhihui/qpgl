using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 客户账务往来
    /// </summary>
    [DataContract]
    public class Customeraccountsdealings
    {
        /// <summary>
        /// 收款单号
        /// </summary>
        [DataMember]
        public Receivefunds RECEIVEFUNDS
        {
            get; set;
        }

        /// <summary>
        ///客户单据号
        /// </summary>
        [DataMember]
        public string CUSTOMER_TRAN_RECORD
        {
            get; set;
        }

        /// <summary>
        ///单据结算金额
        /// </summary>
        [DataMember]
        public double CUSTOMER_CLEARINGAMOUNT
        {
            get; set;
        }

        /// <summary>
        ///客户结算日期
        /// </summary>
        [DataMember]
        public DateTime CUSTOMER_CLEARINGDATE
        {
            get; set;
        }

        /// <summary>
        ///客户结算人
        /// </summary>
        [DataMember]
        public string CUSTOMER_CLEARMAKER
        {
            get; set;
        }
    }
}
