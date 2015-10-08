using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 采购单
    /// </summary>
    [DataContract]
    public class Purchase
    {
        /// <summary>
        ///采购单号
        /// </summary>
        [DataMember]
        public string PURCHASE_ID
        {
            get; set;
        }

        /// <summary>
        ///仓库编号
        /// </summary>
        [DataMember]
        public Warehouse WAREHOUSE
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
        ///采购日期
        /// </summary>
        [DataMember]
        public DateTime PURCHASE_DATE
        {
            get; set;
        }

        /// <summary>
        ///采购总数量
        /// </summary>
        [DataMember]
        public int PURCHASE_TOTALAMOUNT
        {
            get; set;
        }

        /// <summary>
        ///采购总金额
        /// </summary>
        [DataMember]
        public double PURCHASE_TOTALMONEY
        {
            get; set;
        }

        /// <summary>
        ///采购结算总金额
        /// </summary>
        [DataMember]
        public double PURCHASE_TOTALCLEARING
        {
            get; set;
        }

        /// <summary>
        ///采购单备注
        /// </summary>
        [DataMember]
        public string PURCHASE_MEMO
        {
            get; set;
        }

        /// <summary>
        ///采购制单人
        /// </summary>
        [DataMember]
        public string PURCHASE_MAKER
        {
            get; set;
        }

        /// <summary>
        ///采购制单日期
        /// </summary>
        [DataMember]
        public DateTime PURCHASE_MAKEDATE
        {
            get; set;
        }

        /// <summary>
        ///采购复核人
        /// </summary>
        [DataMember]
        public string PURCHASE_REVIEER
        {
            get; set;
        }

        /// <summary>
        ///采购复核日期
        /// </summary>
        [DataMember]
        public DateTime PURCHASE_REVIEWDATE
        {
            get; set;
        }

        /// <summary>
        ///采购打印次数
        /// </summary>
        [DataMember]
        public int PURCHASE_PRINTTIMES
        {
            get; set;
        }

        /// <summary>
        ///采购单版本号
        /// </summary>
        [DataMember]
        public int PURCHASE_VERSION
        {
            get; set;
        }
    }
}
