using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 人员
    /// </summary>
    [DataContract]
    public class Soft_user
    {
        /// <summary>
        /// 人员编号
        /// </summary>
        public string USER_ID
        {
            get;set;
        }
        /// <summary>
        /// 部门编号 部门实体
        /// </summary>
        public Department DEPARTMENT
        {
            get;set;
        }
        /// <summary>
        /// 人员角色编号 人员角色实体
        /// </summary>
        public Userrole USERROLE
        {
            get;set;
        }
        /// <summary>
        /// 姓名
        /// </summary>
        public string USER_NAME
        {
            get;set;
        }
        /// <summary>
        /// 登录名
        /// </summary>
        public string USER_LOGINNAME
        {
            get;set;
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string USER_PASSWORD
        {
            get;set;
        }
        /// <summary>
        /// 是否离职
        /// </summary>
        public int USER_ISLEAVE
        {
            get;set;
        }
    }
}
