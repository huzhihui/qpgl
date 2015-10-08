using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 货运网点
    /// </summary>
    [DataContract]
    public class Freightpoint
    {

        /// <summary>
        /// 网点编号
        /// </summary>
        [DataMember]
        public string FREIGHTPOINT_ID
        {
            get; set;
        }

        /// <summary>
        /// 货运公司编号
        /// </summary>
        [DataMember]
        public Logisticscompany LOGISTICSCOMPANY
        {
            get; set;
        }

        /// <summary>
        /// 网点名称
        /// </summary>
        [DataMember]
        public string FREIGHTPOINT_NAME
        {
            get; set;
        }

        /// <summary>
        /// 网点地址
        /// </summary>
        [DataMember]
        public string FREIGHTPOINT_ADDRESS
        {
            get; set;
        }

        /// <summary>
        /// 网点联系人
        /// </summary>
        [DataMember]
        public string FREIGHTPOINT_CONTACT
        {
            get; set;
        }

        /// <summary>
        /// 网点固定电话
        /// </summary>
        [DataMember]
        public string FREIGHTPOINT_TEL
        {
            get; set;
        }

        /// <summary>
        /// 网点手机号码
        /// </summary>
        [DataMember]
        public string FREIGHTPOINT_MOBILE
        {
            get; set;
        }
    }
}
