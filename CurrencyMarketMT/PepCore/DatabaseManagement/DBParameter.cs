using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepCore.DatabaseManagement
{
    public class DBParameter
    {
        private String dbConn;
        private String procedureName;
        private IEnumerable<SqlParameter> sqlParameters = new List<SqlParameter>();
        private DbConnection dbConnection;

        public DbConnection DBConnection
        {
            get { return dbConnection; }
            set { dbConnection = value; }
        }

        public IEnumerable<SqlParameter> SqlParameters
        {
            get { return sqlParameters; }
            set { sqlParameters = value; }
        }

        public String ProcedureName
        {
            get { return procedureName; }
            set { procedureName = value; }
        }

        public String DBConnectionString
        {
            get { return dbConn; }
            set { dbConn = value; }
        }

    }
}
