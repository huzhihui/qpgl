using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 仓库
    /// </summary>
    [DataContract]
    public class Warehouse
    {

        /// <summary>
        /// 仓库编号
        /// </summary>
        [DataMember]
        public string WAREHOUSEID
        {
            get; set;
        }
        /// <summary>
        /// 仓库名称
        /// </summary>
        [DataMember]
        public string WAREHOUSENAME
        {
            get;set;
        }
    }
}
