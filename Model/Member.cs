using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 会员
    /// </summary>
    [DataContract]
    public class Member
    {
        /// <summary>
        /// 会员编号
        /// </summary>
        [DataMember]
        public string MEMBER_ID
        {
            get; set;
        }

        /// <summary>
        /// 会员类型编号
        /// </summary>
        [DataMember]
        public Membertpye MEMBERTPYE
        {
            get; set;
        }

        /// <summary>
        /// 客户编号
        /// </summary>
        [DataMember]
        public Customer CUSTOMER
        {
            get; set;
        }

        /// <summary>
        /// 入会日期
        /// </summary>
        [DataMember]
        public DateTime MEMBER_JOINDATE
        {
            get; set;
        }

        /// <summary>
        /// 会员有效期
        /// </summary>
        [DataMember]
        public DateTime MEMBER_VALIDDATE
        {
            get; set;
        }

        /// <summary>
        /// 会员积分
        /// </summary>
        [DataMember]
        public double MEMBER_VANTAGES
        {
            get; set;
        }
    }
}
