using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 货架
    /// </summary>
    [DataContract]
    public class Shelf
    {
        /// <summary>
        /// 货架编号
        /// </summary>
        [DataMember]
        public string SHELF_ID
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
        /// 货架名
        /// </summary>
        [DataMember]
        public string SHELF_NAME
        {
            get;set;
        }
        /// <summary>
        /// 实际位置
        /// </summary>
        [DataMember]
        public string ACTUALPOSITION
        {
            get;set;
        }
        /// <summary>
        /// 货架容积
        /// </summary>
        [DataMember]
        public int SHELF_VOLUME
        {
            get;set;
        }
        /// <summary>
        /// 归属
        /// </summary>
        [DataMember]
        public string ADSCRIPTION
        {
            get;set;
        }
        /// <summary>
        /// 货架盘点状态
        /// </summary>
        [DataMember]
        public int SHELF_STATUS
        {
            get;set;
        }
    }
}
