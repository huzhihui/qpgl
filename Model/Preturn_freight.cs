using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 采购退货货运单
    /// </summary>
    [DataContract]
    public class Preturn_freight
    {
        /// <summary>
        ///采退货运单号
        /// </summary>
        [DataMember]
        public string PRETURN_FREIGHT_ID
        {
            get; set;
        }

        /// <summary>
        ///采退单号
        /// </summary>
        [DataMember]
        public Purchasereturns PURCHASERETURN
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
        ///采退货运日期
        /// </summary>
        [DataMember]
        public DateTime PRETURN_FREIGHTDATE
        {
            get; set;
        }

        /// <summary>
        ///采退货运做单人
        /// </summary>
        [DataMember]
        public string PRETURN_FREIGHT_MAKER
        {
            get; set;
        }

        /// <summary>
        ///采退货运备注
        /// </summary>
        [DataMember]
        public string PRETURN_FREIGHT_MEMO
        {
            get; set;
        }
    }
}
