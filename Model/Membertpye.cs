using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 会员类别
    /// </summary>
    [DataContract]
    public class Membertpye
    {
        /// <summary>
        /// 会员类型编号
        /// </summary>
        [DataMember]
        public string MEMBERTPYE_ID
        {
            get; set;
        }

        /// <summary>
        /// 会员类型名
        /// </summary>
        [DataMember]
        public string MEMBERTPYE_NAME
        {
            get; set;
        }

        /// <summary>
        /// 会员年费
        /// </summary>
        [DataMember]
        public double MEMBERTPYE_ANNUALFEE
        {
            get; set;
        }

        /// <summary>
        /// 会员扣率
        /// </summary>
        [DataMember]
        public double MEMBERTPYE_DISCOUNT
        {
            get; set;
        }
    }
}
