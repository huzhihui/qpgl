using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 货架配件管理
    /// </summary>
    [DataContract]
    public class Shelfop
    {
        /// <summary>
        /// 管理编号
        /// </summary>
        [DataMember]
        public string OP_ID
        {
            get;set;
        }
        /// <summary>
        /// 源货架编号 
        /// </summary>
        [DataMember]
        public Shelf S_SHELF
        {
            get;set;
        }
        /// <summary>
        /// 目标货架编号
        /// </summary>
        [DataMember]
        public Shelf D_SHELF
        {
            get;set;
        }
        /// <summary>
        /// 零件编号
        /// </summary>
        [DataMember]
        public string AUTO_PARTSID
        {
            get;set;
        }
        /// <summary>
        /// 操作方式
        /// </summary>
        [DataMember]
        public int OP
        {
            get;set;
        }
        /// <summary>
        /// 数量
        /// </summary>
        [DataMember]
        public int OP_AMOUNT
        {
            get;set;
        }
        /// <summary>
        /// 操作人
        /// </summary>
        [DataMember]
        public string OP_MAKER
        {
            get;set;
        }
        /// <summary>
        /// 操作日期
        /// </summary>
        [DataMember]
        public DateTime OP_DATE
        {
            get;set;
        }
    }
}
