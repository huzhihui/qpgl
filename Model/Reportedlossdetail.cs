using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 报损明细
    /// </summary>
    [DataContract]
    public class Reportedlossdetail
    {
        /// <summary>
        /// 报损实体
        /// </summary>
        [DataMember]
        public Reportedloss REPORTEDLOSS
        {
            get;set;
        }
        /// <summary>
        /// 零件实体
        /// </summary>
        [DataMember]
        public Autoparts AUTOPARTS
        {
            get;set;
        }
        /// <summary>
        /// 报损序号
        /// </summary>
        [DataMember]
        public int REPORTEDLOSS_NO
        {
            get;set;
        }
        /// <summary>
        /// 报损数量
        /// </summary>
        [DataMember]
        public int REPORTEDLOSS_AMOUNT
        {
            get;set;
        }
        /// <summary>
        /// 报损批次
        /// </summary>
        [DataMember]
        public int REPORTEDLOSS_BATCH
        {
            get;set;
        }
        /// <summary>
        /// 报损价
        /// </summary>
        [DataMember]
        public double REPORTEDLOSS_PRICE
        {
            get;set;
        }
    }
}
