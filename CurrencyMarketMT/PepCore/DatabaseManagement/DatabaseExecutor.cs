using PepCore.LogManagement;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepCore.DatabaseManagement.Interfaces
{
    public class DatabaseExecutor : IDatabaseExecutor
    {
        private readonly ILogger iLogger;
        public DatabaseExecutor(ILogger iLogger)
        {
            this.iLogger = iLogger;
        }
        public async Task<SqlDataReader> ExecuteAsync(DBParameter parameters)
        {
            SqlConnection conn = (SqlConnection)parameters.DBConnection;
            using (SqlCommand command = new SqlCommand())
            {               
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Connection = conn;
                if (parameters.SqlParameters.Any())
                    command.Parameters.AddRange(parameters.SqlParameters.ToArray());
                command.CommandText = parameters.ProcedureName;
                await conn.OpenAsync();
                return await command.ExecuteReaderAsync(); 
            }
        }
    }
}
