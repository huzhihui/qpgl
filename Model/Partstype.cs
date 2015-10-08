using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 型号，类目
    /// </summary>
    [DataContract]
    public class Partstype
    {
        /// <summary>
        /// 类型编号，自编码区分多级类目
        /// </summary>
        [DataMember]
        public string TPYEID
        {
            get; set;
        }

        /// <summary>
        ///类型名称
        /// </summary>
        [DataMember]
        public string TYPENAME
        {
            get; set;
        }
    }
}
