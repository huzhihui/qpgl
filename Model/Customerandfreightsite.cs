using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 客户网点说明
    /// </summary>
    [DataContract]
    public class Customerandfreightsite
    {

        /// <summary>
        /// 网点编号
        /// </summary>
        [DataMember]
        public Freightpoint FREIGHTPOINT
        {
            get; set;
        }

        /// <summary>
        ///客户编号
        /// </summary>
        [DataMember]
        public Customer CUSTOMER
        {
            get; set;
        }

        /// <summary>
        /// 客户网点优先级
        /// </summary>
        [DataMember]
        public int CFREIGHTPOINT_PRIORITY
        {
            get; set;
        }
    }
}
