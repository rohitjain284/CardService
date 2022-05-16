using ClientLibrary.Model;
using Microsoft.Extensions.Configuration;
using System;

namespace ClientLibrary
{
    public class AppConfiguration
    {
        public static AppConfigurationData appConfigurationSettings;
        private IConfiguration Configuration;
        /// <summary>
        /// Loading Configuration
        /// </summary>
        public AppConfiguration(IConfiguration _configuration)
        {
            Configuration = _configuration;
            LoadConfiguration();
        }
        /// <summary>
        /// Method to load configuration
        /// </summary>
        public void LoadConfiguration()
        {
            try
            {
                appConfigurationSettings.HDFCConnectionString = this.Configuration.GetSection("AppSettings")["HdfcConnectionString"];
                appConfigurationSettings.HDFCServiceUrl = this.Configuration.GetSection("AppSettings")["HDFCServiceUrl"];
                appConfigurationSettings.HDFCAuthParams = this.Configuration.GetSection("AppSettings")["HDFCAuthParams"];
                appConfigurationSettings.IciciConnectionString = this.Configuration.GetSection("AppSettings")["IciciConnectionString"];
                appConfigurationSettings.IciciServiceUrl = this.Configuration.GetSection("AppSettings")["IciciServiceUrl"];
                appConfigurationSettings.IciciAuthParams = this.Configuration.GetSection("AppSettings")["iciciAuthParams"];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}