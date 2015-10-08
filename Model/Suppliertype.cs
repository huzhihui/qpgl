using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Model
{
    [DataContract]
    public class Suppliertype
    {
        [DataMember]
        public string SUPPLIERTYPEID
        {
            get;set;
        }
        [DataMember]
        public string SUPPLIERTYPENAME
        {
            get;set;
        }
    }
}
