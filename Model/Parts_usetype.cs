using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 配件用途分类
    /// </summary>
    [DataContract]
    public class Parts_usetype
    {
        /// <summary>
        ///用途分类编码
        /// </summary>
        [DataMember]
        public string CLASS_ID
        {
            get; set;
        }

        /// <summary>
        ///用途分类名称
        /// </summary>
        [DataMember]
        public string CLASS_NAME
        {
            get; set;
        }
    }
}
