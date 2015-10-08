using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 人员角色
    /// </summary>
    [DataContract]
    public class Userrole
    {
        /// <summary>
        /// 人员角色编号
        /// </summary>
        [DataMember]
        public string USERROLE_ID
        {
            get;set;
        }
        /// <summary>
        /// 角色名
        /// </summary>
        [DataMember]
        public string USERROLE_NAME
        {
            get;set;
        }
    }
}
