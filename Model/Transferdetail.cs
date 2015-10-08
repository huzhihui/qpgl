using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 调拨明细
    /// </summary>
    [DataContract]
    public class Transferdetail
    {
        /// <summary>
        /// 调拨单号
        /// </summary>
        [DataMember]
        public Transfer TRANSFER
        {
            get;set;
        }
        /// <summary>
        /// 零件编号
        /// </summary>
        [DataMember]
        public Autoparts AUTO_PARTS
        {
            get;set;
        }
        /// <summary>
        /// 调拨序号
        /// </summary>
        [DataMember]
        public int TRANSFERDETAIL_NO
        {
            get;set;
        }
        /// <summary>
        /// 调拨批次
        /// </summary>
        [DataMember]
        public int TRANSFERDETAIL_BATCH
        {
            get;set;
        }
        /// <summary>
        /// 调拨数量
        /// </summary>
        [DataMember]
        public int TRANSFERDETAIL_AMOUNT
        {
            get;set;
        }
        /// <summary>
        /// 调拨成本
        /// </summary>
        [DataMember]
        public double TRANSFERDETAIL_COST
        {
            get;set;
        }
    }
}
