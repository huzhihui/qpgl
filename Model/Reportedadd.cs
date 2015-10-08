using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    [DataContract]
    public class Reportedadd
    {
        [DataMember]
        public string REPORTEDADD_ID
        {
            get;set;
        }
        /// <summary>
        /// 仓库实体
        /// </summary>
        [DataMember]
        public Warehouse WAREHOUSE
        {
            get;set;
        }
        [DataMember]
        public int REPORTEDADD_TOTALAMOUNT
        {
            get;set;
        }
        [DataMember]
        public double REPORTEDADD_TOTALMENEY
        {
            get;set;
        }
        [DataMember]
        public string REPORTEDADD_MEMO
        {
            get;set;
        }
        [DataMember]
        public string REPORTEDADD_MAKER
        {
            get;set;
        }
        [DataMember]
        public DateTime REPORTEDADD_MAKEDATE
        {
            get;set;
        }
        [DataMember]
        public string REPORTEDADD_REVIEWER
        {
            get;set;
        }
        [DataMember]
        public DateTime REPORTEDADD_REVIEWDATE
        {
            get;set;
        }
        [DataMember]
        public int REPORTEDADD_ISCHECK
        {
            get;set;
        }
    }
}
