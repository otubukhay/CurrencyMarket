using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepCore.DatabaseManagement.Interfaces
{
    public abstract class IParamaterExtractor
    {
        public virtual IEnumerable<SqlParameter> ExtractSQLParameters(JObject objects) { return null; }

        protected bool Validate() {
            return true;
        }
    }
}
