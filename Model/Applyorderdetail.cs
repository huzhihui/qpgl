using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 申配明细
    /// </summary>
    [DataContract]
    public class Applyorderdetail
    {
        /// <summary>
        /// 申配单实体
        /// </summary>
        [DataMember]
        public Applyorder APPLYORDER
        {
            get; set;
        }

        /// <summary>
        /// 零件编号
        /// </summary>
        [DataMember]
        public Autoparts AUTO_PARTS
        {
            get; set;
        }

        /// <summary>
        /// 申配零件批次
        /// </summary>
        [DataMember]
        public int APPLY_PARTSBACH
        {
            get; set;
        }

        /// <summary>
        /// 申请零件数量
        /// </summary>
        [DataMember]
        public int APPLY_AMOUNT
        {
            get; set;
        }
    }
}
