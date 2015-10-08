using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 站点
    /// </summary>
    [DataContract]
    public class Site
    {
        /// <summary>
        /// 主机名
        /// </summary>
        [DataMember]
        public string DNSNAME
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
    }
}
