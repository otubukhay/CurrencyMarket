using Newtonsoft.Json.Linq;
using PepCore.DatabaseManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepCore.DatabaseManagement
{
    public class ParamaterExtractor : IParamaterExtractor
    {
        public override IEnumerable<SqlParameter> ExtractSQLParameters(JObject objects) { return new List<SqlParameter>(); }
    }
}
