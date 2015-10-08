using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    /// <summary>
    /// 销售货运明细
    /// </summary>
    [DataContract]
    public class Sell_freightdetail
    {
        /// <summary>
        /// 销售货运实体
        /// </summary>
        [DataMember]
        public Selldetail SELLDETAIL
        {
            get;set;
        }
        /// <summary>
        /// 销售实体
        /// </summary>
        [DataMember]
        public Sell SELL
        {
            get;set;
        }
        /// <summary>
        /// 销售序号
        /// </summary>
        [DataMember]
        public int SELLDETAIL_NO
        {
            get;set;
        }
        /// <summary>
        /// 销售货运实发数量
        /// </summary>
        [DataMember]
        public int SELL_FREIGHTAMOUNT
        {
            get;set;
        }
        /// <summary>
        /// 销售货运明细备注
        /// </summary>
        [DataMember]
        public string SELL_FREIGHT_DETAILMEMO
        {
            get;set;
        }
    }
}
