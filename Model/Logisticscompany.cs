using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 货运物流公司
    /// </summary>
    [DataContract]
    public class Logisticscompany
    {
        /// <summary>
        /// 货运公司编号
        /// </summary>
        [DataMember]
        public string LOGISTICSCOMPANY_ID
        {
            get; set;
        }

        /// <summary>
        /// 货运公司名称
        /// </summary>
        [DataMember]
        public string LOGISTICSCOMPANY_NAME
        {
            get; set;
        }

        /// <summary>
        /// 货运公司地址
        /// </summary>
        [DataMember]
        public string LOGISTICSCOMPANY_ADDRESS
        {
            get; set;
        }

        /// <summary>
        /// 货运公司联系人
        /// </summary>
        [DataMember]
        public string LOGISTICSCOMPANY_CONTACT
        {
            get; set;
        }

        /// <summary>
        /// 货运公司固定电话
        /// </summary>
        [DataMember]
        public string LOGISTICSCOMPANY_TEL
        {
            get; set;
        }

        /// <summary>
        /// 货运公司手机号码
        /// </summary>
        [DataMember]
        public string LOGISTICSCOMPANY_MOBILE
        {
            get; set;
        }
    }
}
