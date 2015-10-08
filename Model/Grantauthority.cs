using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 权限角色对应
    /// </summary>
    [DataContract]
    public class Grantauthority
    {
        /// <summary>
        /// 权限编号
        /// </summary>
        [DataMember]
        public Authority AUTHORITY
        {
            get; set;
        }

        /// <summary>
        /// 人员角色编号
        /// </summary>
        [DataMember]
        public Userrole USERROLE
        {
            get; set;
        }

        /// <summary>
        /// 是否授权
        /// </summary>
        [DataMember]
        public int ISAUTHORITY
        {
            get; set;
        }
    }
}
