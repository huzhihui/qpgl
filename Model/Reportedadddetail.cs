using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 报溢明细
    /// </summary>
    [DataContract]
    public class Reportedadddetail
    {
        /// <summary>
        /// 零件实体
        /// </summary>
        [DataMember]
        public Autoparts AUTOPARTS
        {
            get;set;
        }
        /// <summary>
        /// 报溢单号
        /// </summary>
        [DataMember]
        public Reportedadd REPORTEDADD
        {
            get;set;
        }
        /// <summary>
        /// 报溢序号
        /// </summary>
        [DataMember]
        public int REPORTEDADD_NO
        {
            get;set;
        }
        /// <summary>
        /// 报溢数量
        /// </summary>
        [DataMember]
        public int REPORTEDADD_AMOUNT
        {
            get;set;
        }
        /// <summary>
        /// 报溢批次
        /// </summary>
        [DataMember]
        public int REPORTEDADD_BATCH
        {
            get;set;
        }
        /// <summary>
        /// 报溢价
        /// </summary>
        [DataMember]
        public double REPORTEDADD_PRICE
        {
            get;set;
        }
    }
}
