using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
using System.Configuration;
namespace DAL
{
    public class OraHelper
    {
        private string connectionString = ConfigurationManager.AppSettings["qcgl"].ToString();
    }
}
