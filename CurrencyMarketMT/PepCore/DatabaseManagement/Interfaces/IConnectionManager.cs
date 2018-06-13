using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepCore.DatabaseManagement
{
    public abstract class IConnectionManager    {
        public virtual DbConnection GetConnection(String dbConnectionName) {
            return null;
        }
    }
}
