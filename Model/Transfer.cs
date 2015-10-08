using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 调拨单
    /// </summary>
    [DataContract]
    public class Transfer
    {
        /// <summary>
        /// 调拨单号
        /// </summary>
        [DataMember]
        public string TRANSFER_ID
        {
            get;set;
        }
        /// <summary>
        /// 源仓库编号
        /// </summary>
        [DataMember]
        public Warehouse S_WAREHOUSE
        {
            get;set;
        }
        /// <summary>
        /// 目标仓库编号
        /// </summary>
        [DataMember]
        public Warehouse D_WAREHOUSE
        {
            get;set;
        }
        /// <summary>
        /// 调拨日期
        /// </summary>
        [DataMember]
        public DateTime TRANSFER_DATE
        {
            get;set;
        }
        /// <summary>
        /// 调拨备注
        /// </summary>
        [DataMember]
        public string TRANSFER_MEMO
        {
            get;set;
        }
        /// <summary>
        /// 调拨人
        /// </summary>
        [DataMember]
        public string TRANSFER_MAKER
        {
            get;set;
        }
        /// <summary>
        /// 调拨复核人
        /// </summary>
        [DataMember]
        public string TRANSFER_REVIEWER
        {
            get;set;
        }
        /// <summary>
        /// 调拨复核日期
        /// </summary>
        [DataMember]
        public DateTime TRANSFER_REVIEWDATE
        {
            get;set;
        }
        /// <summary>
        /// 调拨状态
        /// </summary>
        [DataMember]
        public int TRANSFER_STATE
        {
            get;set;
        }
    }
}
