using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 零件包
    /// </summary>
    [DataContract]
    public class Partspackage
    {
        /// <summary>
        /// 零件包编号
        /// </summary>
        [DataMember]
        public string PARTSPACKAGE_ID
        {
            get; set;
        }

        /// <summary>
        /// 零件
        /// </summary>
        [DataMember]
        public Autoparts AUTOPARTS
        {
            get; set;
        }
    }
}
