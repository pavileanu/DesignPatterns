using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    interface ISettings
    {
        public string getConfig();
    }

    public class Settings : ISettings
    {
        string _config;
        public Settings(string config)
        {
            _config = config;
        }        
        public string getConfig() => _config;
    }

    public class RemoteSettings:ISettings   // AICI REMOTESETTINGS E PROXY IN TIMP CE ASCUTEM SETTINGS-UL
    {
        private Settings settings;
        public RemoteSettings(string address) 
        {
            settings = new Settings(address);
        }
        public string getConfig() => settings.getConfig();
    }

    public class LazySettings : ISettings   // AICI LAZYSETTINGS E PROXY IN TIMP CE ASCUTEM SETTINGS-UL
    {
        private Settings settings;
        private string _address;
        public LazySettings(string address)
        {
            _address = address;
        }
        public string getConfig()
        {
            settings = new Settings(_address);
            return settings.getConfig();
        }
    }
}
