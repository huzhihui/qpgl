using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 盘点
    /// </summary>
    [DataContract]
    public class Inventory
    {
        /// <summary>
        /// 仓库编号
        /// </summary>
        [DataMember]
        public Warehouse WAREHOUSE
        {
            get; set;
        }

        /// <summary>
        /// 货架编号
        /// </summary>
        [DataMember]
        public Shelf SHELF
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
        /// 盘点零件批次
        /// </summary>
        [DataMember]
        public int INVENTORY_BATCH
        {
            get; set;
        }

        /// <summary>
        /// 盘点前数量
        /// </summary>
        [DataMember]
        public int BEFORENUMBER
        {
            get; set;
        }

        /// <summary>
        /// 盘点后数量
        /// </summary>
        [DataMember]
        public int AFTERUMBER
        {
            get; set;
        }

        /// <summary>
        /// 盘点人
        /// </summary>
        [DataMember]
        public string INVENTORY_MAKER
        {
            get; set;
        }

        /// <summary>
        /// 盘点日期
        /// </summary>
        [DataMember]
        public DateTime INVENTORY_MAKEDATE
        {
            get; set;
        }

        /// <summary>
        /// 复核人
        /// </summary>
        [DataMember]
        public string INVENTORY_REVIEWER
        {
            get; set;
        }

        /// <summary>
        /// 复核日期
        /// </summary>
        [DataMember]
        public DateTime INVENTORY_REVIEWDATE
        {
            get; set;
        }

        /// <summary>
        /// 盘点状态
        /// </summary>
        [DataMember]
        public int INVENTORY_STATUS
        {
            get; set;
        }
    }
}
