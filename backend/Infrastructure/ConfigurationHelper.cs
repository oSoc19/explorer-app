using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace backend.Infrastructure{
    public class ConfigurationHelper
    {
        private readonly string _configFileName;
        private readonly IConfiguration _config;
        public ConfigurationHelper(string fileName)
        {
            _configFileName = fileName;
            string expectedConfigurationFilePath = Path.Combine(Directory.GetCurrentDirectory(), _configFileName);
            if (!File.Exists(expectedConfigurationFilePath))
            {
                throw new FileNotFoundException($"The file of secret configuration couldn't be found. It must be a JSON file named {_configFileName} containing sensitive data.", expectedConfigurationFilePath);
            }
            _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(_configFileName)
                .Build();
        }
        public string Get(string key)
        {
            string value = _config.GetValue<string>(key);
            if (String.IsNullOrEmpty(value))
            {
                throw new InvalidOperationException($"The file doesn't have a key-value pair registered as {key}.");
            }
            return value;
        }
    }
}