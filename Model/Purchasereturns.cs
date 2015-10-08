using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 采退单
    /// </summary>
    [DataContract]
    public class Purchasereturns
    {
        /// <summary>
        /// 采退单号
        /// </summary>
        [DataMember]
        public string PURCHASERETURNID
        {
            get;set;
        }
        /// <summary>
        /// 供应商实体
        /// </summary>
        [DataMember]
        public Supplier SUPPLIER
        {
            get;set;
        }
        /// <summary>
        /// 仓库实体
        /// </summary>
        [DataMember]
        public Warehouse WAREHOUSE
        {
            get;set;
        }
        /// <summary>
        /// 采退货运单实体
        /// </summary>
        [DataMember]
        public Preturn_freight PRETURN_FREIGHT
        {
            get;set;
        }
        /// <summary>
        /// 采退日期
        /// </summary>
        [DataMember]
        public DateTime PRETURN_DATE
        {
            get;set;
        }
        /// <summary>
        /// 采退总数量
        /// </summary>
        [DataMember]
        public int PRETURN_TOTALAMOUNT
        {
            get;set;
        }
        /// <summary>
        /// 采退总金额
        /// </summary>
        [DataMember]
        public double PRETURN_TOTALMENEY
        {
            get;set;
        }
        /// <summary>
        /// 采退结算总金额
        /// </summary>
        [DataMember]
        public double PRETURN_TOTALCLEARING
        {
            get;set;
        }
        /// <summary>
        /// 采退备注
        /// </summary>
        [DataMember]
        public string PRETURN_MEMO
        {
            get;set;
        }
        /// <summary>
        /// 采退制单人
        /// </summary>
        [DataMember]
        public string PRETURN_MAKER
        {
            get;set;
        }
        /// <summary>
        /// 采退制单日期
        /// </summary>
        [DataMember]
        public DateTime PRETURN_MAKEDATE
        {
            get;set;
        }
        /// <summary>
        /// 采退复核人
        /// </summary>
        [DataMember]
        public string PRETURN_REVIEWER
        {
            get;set;
        }
        /// <summary>
        /// 采退复核日期
        /// </summary>
        [DataMember]
        public DateTime PRETURN_REVIEWDATE
        {
            get;set;
        }
        /// <summary>
        /// 采退打印次数
        /// </summary>
        [DataMember]
        public int PRETURN_PRINTTIME
        {
            get;set;
        }
        /// <summary>
        /// 采退单版本
        /// </summary>
        [DataMember]
        public int PRETURN_VERSION
        {
            get;set;
        }
    }
}
