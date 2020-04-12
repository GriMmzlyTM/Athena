using System.IO;
using Athena.Models.Config;
using YamlDotNet.Serialization;

namespace Athena.Services.Config
{
    public class ApplicationConfigService : IApplicationConfigService
    {
        private readonly string _configPath = $"{System.AppDomain.CurrentDomain.BaseDirectory}/AthenaConfig.yml";

        public ApplicationConfigModel Config { get; private set; }

        public ApplicationConfigService()
        {
            var configData = File.ReadAllText(_configPath);

            Config = new Deserializer().Deserialize<ApplicationConfigModel>(configData);
        }

        public ApplicationConfigModel GetConfig() => Config;
    }
}
