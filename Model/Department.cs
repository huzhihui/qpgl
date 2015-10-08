using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 人员部门
    /// </summary>
    [DataContract]
    public class Department
    {
        /// <summary>
        /// 部门编号
        /// </summary>
        [DataMember]
        public string DEPARTMENT_ID
        {
            get; set;
        }

        /// <summary>
        /// 部门名称
        /// </summary>
        [DataMember]
        public string DEPARTMENT_NAME
        {
            get; set;
        }

        /// <summary>
        /// 部门描述
        /// </summary>
        [DataMember]
        public string DEPARTMENT_DISC
        {
            get; set;
        }
    }
}
