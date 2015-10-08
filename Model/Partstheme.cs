using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{

    /// <summary>
    /// 配件主题
    /// </summary>
    [DataContract]
    public class Partstheme
    {
        /// <summary>
        /// 主题编号
        /// </summary>
        [DataMember]
        public string THEME_ID
        {
            get; set;
        }

        /// <summary>
        /// 主题名称
        /// </summary>
        [DataMember]
        public string THEME_NAME
        {
            get; set;
        }

        /// <summary>
        /// 主题描述
        /// </summary>
        [DataMember]
        public string THEME_DISC
        {
            get; set;
        }
    }
}
