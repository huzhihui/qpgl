using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 客户类型
    /// </summary>
    [DataContract]
    public class Customertype
    {
        /// <summary>
        /// 类型编号
        /// </summary>
        [DataMember]
        public string CUSTOMERTYPEID
        {
            get; set;
        }

        /// <summary>
        ///类型名称
        /// </summary>
        [DataMember]
        public string CUSTOMERTYPENAME
        {
            get; set;
        }
    }
}
