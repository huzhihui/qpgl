using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 库存
    /// </summary>
    [DataContract]
    public class Stock
    {
        /// <summary>
        /// 零件编号 零件实体
        /// </summary>
        [DataMember]
        public Autoparts AUTOPARTS
        {
            get;set;
        }
        /// <summary>
        /// 仓库编号 仓库实体
        /// </summary>
        [DataMember]
        public Warehouse WAREHOUSE
        {
            get;set;
        }
        /// <summary>
        /// 库存批次
        /// </summary>
        [DataMember]
        public int STOCKS_BATCH
        {
            get;set;
        }
        /// <summary>
        /// 库存数
        /// </summary>
        [DataMember]
        public int STOCKS_AMOUNT
        {
            get;set;
        }
        /// <summary>
        /// 库存成本价
        /// </summary>
        [DataMember]
        public double STOCKSCOST
        {
            get;set;
        }
    }
}
