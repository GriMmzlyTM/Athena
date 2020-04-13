using System.IO;
using Athena.Models.Config;
using Athena.Models.Payloads;
using YamlDotNet.Serialization;

namespace Athena.Services.Config
{
    public class ApplicationUpdateConfigService : IApplicationUpdateConfigService
    {

        private readonly string _configPath = $"{System.AppDomain.CurrentDomain.BaseDirectory}/AthenaConfig.yml";

        private ApplicationConfigModel _applicationConfig { get; }

        public ApplicationUpdateConfigService(
            ApplicationConfigModel applicationConfig)
        {
            _applicationConfig = applicationConfig;
        }

        public void Execute() =>
            _applicationConfig.Update(
                    new Deserializer()
                    .Deserialize<ApplicationConfigModel>(
                        File.ReadAllText(_configPath)));

        public void Execute<TServicePayload>(TServicePayload payload) where TServicePayload : class, IServicePayload =>
            Execute();
    }

}
