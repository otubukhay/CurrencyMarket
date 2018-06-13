using Newtonsoft.Json.Linq;
using PepCore.LogManagement;
using PepCore.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepCore.DatabaseManagement.Interfaces
{
    public abstract class IDatabaseManager
    {
        protected readonly ILogger iLogger;
        protected readonly IConnectionManager iconnectionManager;
        protected readonly IDatabaseExecutor iDatabaseExecutor;
        protected readonly IParamaterExtractor iParameterExtractor;
        public IDatabaseManager(ILogger iLogger, IConnectionManager iConnectionManager,
                                IDatabaseExecutor iDatabaseExecutor, IParamaterExtractor iParameterExtractor)
        {
            this.iLogger = iLogger;
            this.iconnectionManager = iConnectionManager;
            this.iDatabaseExecutor = iDatabaseExecutor;
            this.iParameterExtractor = iParameterExtractor;
        }

        public virtual Task<PepTable> GetDataAsync(string connectionStringName,
                                             string procedureName, JObject parameters = null)
        {
            return null;
        }

        protected DbConnection GetConnection(string connectionStringName)
        {
            return this.iconnectionManager.GetConnection(connectionStringName);
        }
    }
}
