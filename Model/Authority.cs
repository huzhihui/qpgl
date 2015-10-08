using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{
    /// <summary>
    /// 权限
    /// </summary>
    [DataContract]
    public class Authority
    {

        /// <summary>
        /// 权限编号
        /// </summary>
        [DataMember]
        public string AUTHORITY_ID
        {
            get; set;
        }

        /// <summary>
        /// 权限名称
        /// </summary>
        [DataMember]
        public string AUTHORITY_NAME
        {
            get; set;
        }

        /// <summary>
        /// 菜单项
        /// </summary>
        [DataMember]
        public string MENU_ID      //TODO
        {
            get; set;
        }

        /// <summary>
        /// 快捷项
        /// </summary>
        [DataMember]
        public string TOOL_ID      //TODO
        {
            get; set;
        }
    }
}
