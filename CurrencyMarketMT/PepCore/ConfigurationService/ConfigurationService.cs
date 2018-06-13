using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepCore.ConfigurationService
{
    public class ConfigurationService : IConfigurationService
    {
        public String GetConfigValue(string key)
        {
            string res = "";
            try
            {
               res = System.Configuration.ConfigurationManager.ConnectionStrings[key].ConnectionString;
            }
            catch (ConfigurationErrorsException)
            {

            }

            return res;
        }

        public bool SaveConfigValue(string key, string value)
        {
            return true;
        }
    }
}
