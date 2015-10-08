using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 车款
    /// </summary>
    [DataContract]
    public class Carcollection
    {
        /// <summary>
        /// 车款编号
        /// </summary>
        [DataMember]
        public string CARCOLLECTION_ID
        {
            get; set;
        }

        /// <summary>
        /// 车系编号
        /// </summary>
        [DataMember]
        public Carseries CARSERIES
        {
            get; set;
        }

        /// <summary>
        /// 车款年限
        /// </summary>
        [DataMember]
        public string MADEYEAR
        {
            get; set;
        }

        /// <summary>
        /// 发动机类型
        /// </summary>
        [DataMember]
        public string ENGINETPYE
        {
            get; set;
        }
    }
}
