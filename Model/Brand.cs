using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Model
{

    /// <summary>
    /// 品牌
    /// </summary>
    [DataContract]
    public class Brand
    {
        /// <summary>
        /// 品牌编号
        /// </summary>
        [DataMember]
        public string BRAND_ID
        {
            get; set;
        }

        // <summary>
        ///品牌名称
        /// </summary>
        [DataMember]
        public string BRAND_NAME
        {
            get; set;
        }
    }
}
