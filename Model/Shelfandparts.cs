using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// ShelfAndparts
    /// </summary>
    [DataContract]
    public class Shelfandparts
    {
        /// <summary>
        /// 货架编号 货架实体
        /// </summary>
        [DataMember]
        public Shelf SHELF
        {
            get;set;
        }
        /// <summary>
        /// 零件编号 零件实体
        /// </summary>
        [DataMember]
        public Autoparts AUTOPARTS
        {
            get;set;
        }
        /// <summary>
        /// 存放数量
        /// </summary>
        [DataMember]
        public int STORE_AMOUNT
        {
            get;set;
        }
        [DataMember]
        public int PARTS_BATCH
        {
            get;set;
        }
    }
}
