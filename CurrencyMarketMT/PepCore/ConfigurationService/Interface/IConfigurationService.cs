using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepCore.ConfigurationService
{
    public interface IConfigurationService
    {
        string GetConfigValue(string key);

        bool SaveConfigValue(string key, String value);
    }
}
