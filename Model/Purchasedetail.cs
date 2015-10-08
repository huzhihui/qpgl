using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 采购单明细
    /// </summary>
    [DataContract]
    public class Purchasedetail
    {
        /// <summary>
        ///采购单号
        /// </summary>
        [DataMember]
        public Purchase PURCHASE
        {
            get; set;
        }

        /// <summary>
        ///零件编号
        /// </summary>
        [DataMember]
        public Autoparts AUTO_PARTS
        {
            get; set;
        }

        /// <summary>
        ///采购序号
        /// </summary>
        [DataMember]
        public int PURCHASE_NO
        {
            get; set;
        }

        /// <summary>
        ///采购数量
        /// </summary>
        [DataMember]
        public int PURCHASE_AMOUNT
        {
            get; set;
        }

        /// <summary>
        ///采购价
        /// </summary>
        [DataMember]
        public double PURCHASE_PRICE
        {
            get; set;
        }

        /// <summary>
        ///采购扣率
        /// </summary>
        [DataMember]
        public double PURCHASE_DISCOUNT
        {
            get; set;
        }

        /// <summary>
        ///采购批次
        /// </summary>
        [DataMember]
        public int PURCHASE_BATCH
        {
            get; set;
        }

        /// <summary>
        ///采购明细备注
        /// </summary>
        [DataMember]
        public string PURCHASE_DETAILMEMO
        {
            get; set;
        }

        /// <summary>
        ///采购结算金额
        /// </summary>
        [DataMember]
        public double PURCHASE_DETAILCLEARING
        {
            get; set;
        }

        /// <summary>
        ///采购方式
        /// </summary>
        [DataMember]
        public int PURCHASE_TYPE
        {
            get; set;
        }

        /// <summary>
        ///采购复核记录
        /// </summary>
        [DataMember]
        public string PURCHASE_REMARK
        {
            get; set;
        }
    }
}
