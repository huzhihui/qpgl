using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 报损单
    /// </summary>
    [DataContract]
    public class Reportedloss
    {
        /// <summary>
        /// 报损单号
        /// </summary>
        [DataMember]
        public string REPORTEDLOSS_ID
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
        /// 报损总数
        /// </summary>
        [DataMember]
        public int REPORTEDLOSS_TOTALAMOUNT
        {
            get;set;
        }
        /// <summary>
        /// 报损总金额
        /// </summary>
        [DataMember]
        public double REPORTEDLOSS_TOTALMONEY
        {
            get;set;
        }
        /// <summary>
        /// 报损备注
        /// </summary>
        [DataMember]
        public string REPORTEDLOSS_MEMO
        {
            get;set;
        }
        /// <summary>
        /// 报损人
        /// </summary>
        [DataMember]
        public string REPORTEDLOSS_MAKER
        {
            get;set;
        }
        /// <summary>
        /// 报损日期
        /// </summary>
        [DataMember]
        public DateTime REPORTEDLOSS_MAKEDATE
        {
            get;set;
        }
        /// <summary>
        /// 报损复核人
        /// </summary>
        [DataMember]
        public string REPORTEDLOSS_REVIEWER
        {
            get;set;
        }
        /// <summary>
        /// 报损复核日期
        /// </summary>
        [DataMember]
        public DateTime REPORTEDLOSS_REVIEWDATE
        {
            get;set;
        }
        /// <summary>
        /// 报损确认
        /// </summary>
        [DataMember]
        public int REPORTEDLOSS_ISCHECK
        {
            get;set;
        }
    }
}
