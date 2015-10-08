using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 零件来源分类
    /// </summary>
    [DataContract]
    public class Auto_partssource
    {
        /// <summary>
        /// 配件来源编号
        /// </summary>
        [DataMember]
        public string SOUCE_ID
        {
            get; set;
        }

        // <summary>
        /// 配件来源名称
        /// </summary>
        [DataMember]
        public string SOURCE_NAME
        {
            get; set;
        }
    }
}
