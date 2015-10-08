using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 粘度
    /// </summary>
    [DataContract]
    public class Viscosity
    {
        [DataMember]
        /// <summary>
        /// 粘度ID
        /// </summary>
        public string VISCOSITYID
        {
            get; set;
        }
        [DataMember]
        /// <summary>
        /// 粘度名
        /// </summary>
        public string VISCOSITYNAME
        {
            get;set;
        }
    }
}
