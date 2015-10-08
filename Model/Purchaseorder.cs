using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 采购订单
    /// </summary>
    [DataContract]
    public class Purchaseorder
    {
        /// <summary>
        ///订单编号
        /// </summary>
        [DataMember]
        public string PURCHASEORDERID
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
        ///订单日期
        /// </summary>
        [DataMember]
        public DateTime PURCHASEORDEDATE
        {
            get; set;
        }

        /// <summary>
        ///订单零件总数
        /// </summary>
        [DataMember]
        public int ORDERTOTALAMOUNT
        {
            get; set;
        }

        /// <summary>
        ///订单总金额
        /// </summary>
        [DataMember]
        public double ORDERTOTALMONEY
        {
            get; set;
        }

        /// <summary>
        ///采购订单备注
        /// </summary>
        [DataMember]
        public string ORDER_RECORDMEMO
        {
            get; set;
        }

        /// <summary>
        ///采定制单人
        /// </summary>
        [DataMember]
        public string ORDER_MAKER
        {
            get; set;
        }

        /// <summary>
        ///采定制单日期
        /// </summary>
        [DataMember]
        public DateTime ORDER_MAKEDATE
        {
            get; set;
        }

        /// <summary>
        ///采定复核人
        /// </summary>
        [DataMember]
        public string ORDER_REVIEWER
        {
            get; set;
        }

        /// <summary>
        ///采定复核日期
        /// </summary>
        [DataMember]
        public DateTime ORDER_REVIEWDATE
        {
            get; set;
        }
    }
}
