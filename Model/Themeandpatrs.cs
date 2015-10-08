using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 主题与零件
    /// </summary>
    [DataContract]
    public class Themeandpatrs
    {
        /// <summary>
        /// 零件编号
        /// </summary>
        [DataMember]
        public Autoparts AUTO_PARTS
        {
            get;set;
        }
        /// <summary>
        /// 主题编号
        /// </summary>
        [DataMember]
        public Partstheme THEME
        {
            get;set;
        }
    }
}
