using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepCore.DatabaseManagement
{
    public interface IDatabaseExecutor
    {
        Task<SqlDataReader> ExecuteAsync(DBParameter parameters);
    }
}
