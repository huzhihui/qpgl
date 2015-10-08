using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 销退单
    /// </summary>
    [DataContract]
    public class Sellreturn
    {
        /// <summary>
        /// 销退单号
        /// </summary>
        [DataMember]
        public string SRETURN_ID
        {
            get;set;
        }
        /// <summary>
        /// 客户编号 客户实体
        /// </summary>
        [DataMember]
        public Customer CUSTOMER
        {
            get;set;
        }
        /// <summary>
        /// 仓库编号 仓库实体
        /// </summary>
        [DataMember]
        public Warehouse  WAREHOUSE
        {
            get;set;
        }
        /// <summary>
        /// 销退日期
        /// </summary>
        [DataMember]
        public DateTime SRETURN_DATE
        {
            get;set;
        }
        /// <summary>
        /// 销退总数量
        /// </summary>
        [DataMember]
        public int SRETURN_TOTALAMOUNT
        {
            get;set;
        }
        /// <summary>
        /// 销退总金额
        /// </summary>
        [DataMember]
        public double SRETURN_TOTALMONEY
        {
            get;set;
        }
        /// <summary>
        /// 销退备注
        /// </summary>
        [DataMember]
        public string SRETURN_MEMO
        {
            get;set;
        }
        /// <summary>
        /// 销退结算总金额
        /// </summary>
        [DataMember]
        public double SRETURN_TOTALCLEARING
        {
            get;set;
        }
        /// <summary>
        /// 销退制单人
        /// </summary>
        [DataMember]
        public string SRETURN_MAKER
        {
            get;set;
        }
        /// <summary>
        /// 销退制单日期
        /// </summary>
        [DataMember]
        public DateTime SRETURN_MAKEDATE
        {
            get;set;
        }
        /// <summary>
        /// 销退复核人
        /// </summary>
        [DataMember]
        public string SRETURN_REVIEWER
        {
            get;set;
        }
        /// <summary>
        /// 销退复核日期
        /// </summary>
        [DataMember]
        public DateTime SRETURN_REVIEWDATE
        {
            get;set;
        }
        /// <summary>
        /// 销退打印次数
        /// </summary>
        [DataMember]
        public int SRETURN_PRINTTIME
        {
            get;set;
        }
        /// <summary>
        /// 销t退单版本
        /// </summary>
        [DataMember]
        public int SRETURN_VERSION
        {
            get;set;
        }
    }
}
