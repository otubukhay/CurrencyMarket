using PepCore.ConfigurationService;
using PepCore.DatabaseManagement;
using PepCore.DatabaseManagement.Interfaces;
using PepCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggerConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabaseManager mgr = new DatabaseManager(null, new ConnectionManager(new ConfigurationService()),
                                                       new DatabaseExecutor(null), new ParamaterExtractor());

            mgr.GetDataAsync("MarketDBConn", "[MarketAdministrator].[GetTestData]", null).Wait();
            Console.WriteLine("finished");
            Console.ReadKey();
        }
    }
}
