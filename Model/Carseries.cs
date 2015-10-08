using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 车系
    /// </summary>
    [DataContract]
    public class Carseries
    {
        /// <summary>
        /// 车系编号
        /// </summary>
        [DataMember]
        public string CARSERIES_ID
        {
            get; set;
        }

        /// <summary>
        /// 品牌编号
        /// </summary>
        [DataMember]
        public Brand BRAND
        {
            get; set;
        }

        /// <summary>
        /// 车系名称
        /// </summary>
        [DataMember]
        public string CARSERIES_NAME
        {
            get; set;
        }
    }
}
