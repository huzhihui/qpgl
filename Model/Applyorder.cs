using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 申配单
    /// </summary>
    [DataContract]
    public class Applyorder
    {


        /// <summary>
        /// 申配号
        /// </summary>
        [DataMember]
        public string APPLYORDER_ID
        {
            get; set;
        }

        /// <summary>
        /// 申请仓库编号
        /// </summary>
        [DataMember]
        public Warehouse S_WAREHOUSE
        {
            get; set;
        }

        /// <summary>
        /// 被申请仓库编号
        /// </summary>
        [DataMember]
        public Warehouse D_WAREHOUSE
        {
            get; set;
        }

        /// <summary>
        /// 申配备注
        /// </summary>
        [DataMember]
        public string APPLYORDER_MEMO
        {
            get; set;
        }

        /// <summary>
        /// 申配人
        /// </summary>
        [DataMember]
        public string APPLYORDER_MAKER
        {
            get; set;
        }

        /// <summary>
        /// 申配日期
        /// </summary>
        [DataMember]
        public DateTime APPLYORDER_MAKEDATE
        {
            get; set;
        }

        /// <summary>
        /// 处理人
        /// </summary>
        [DataMember]
        public string APPLYORDER_DEALER
        {
            get; set;
        }

        /// <summary>
        /// 处理日期
        /// </summary>
        [DataMember]
        public DateTime APPLYORDER_DEALDATE
        {
            get; set;
        }
    }
}
