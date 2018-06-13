using PepCore.ConfigurationService;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepCore.DatabaseManagement
{
    public class ConnectionManager : IConnectionManager
    {
        private readonly IConfigurationService iConfigurationService;

        public ConnectionManager(IConfigurationService iConfigurationService)
        {
            this.iConfigurationService = iConfigurationService;
        }
        public override DbConnection GetConnection(String dbConnectionName)
        {
            if (String.IsNullOrEmpty(dbConnectionName))
                throw new Exception("DBConnection name can not be empty");

            String connectionString = iConfigurationService.GetConfigValue(dbConnectionName);
            if (String.IsNullOrEmpty(connectionString))
                throw new Exception("connection info not defined in config file");

            return new SqlConnection(connectionString);
        }
    }
}
