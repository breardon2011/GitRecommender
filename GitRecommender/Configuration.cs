using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Xml; 

namespace GitRecommender
{
	public class Configuration
	{

        private readonly IConfiguration _configuration; 

        // json not available for Android, Mac OS
        public Configuration()
        {
            var builder = new ConfigurationBuilder()
                .Add(new XmlConfigurationSource { Path = "config.xml" });

            _configuration = builder.Build();
        }

        public string ReadToken()
        {

            return _configuration["Token"];
        }
    }



}

