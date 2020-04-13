using Athena.Models.Config;
using Athena.Models.Payloads;
using RiotSharp;

namespace Athena.Services.Riot
{
    /// <summary>
    /// Entrypoint for accessing Riot API in services.
    /// Services have no concept of the RIOT API library/s and instead
    /// communicate with this service as a middleman.
    /// </summary>
    public class RiotAPIService : IService
    {
        private readonly ApplicationConfigModel _applicationConfig;
        private RiotApi _riotApi { get; set; }

        public RiotAPIService(
            ApplicationConfigModel applicationConfig)
        {
            _applicationConfig = applicationConfig;

            ApiValidate();
        }

        private void ApiValidate() =>
            _riotApi = _applicationConfig.EnvironmentEnum == DevelopmentEnvironment.Dev
                ? RiotApi.GetDevelopmentInstance(_applicationConfig.RiotApiConfig.ApiKey)
                : RiotApi.GetInstance(
                    apiKey: _applicationConfig.RiotApiConfig.ApiKey,
                    rateLimitPer10s: _applicationConfig.RiotApiConfig.RateLimitPer10s,
                    rateLimitPer10m: _applicationConfig.RiotApiConfig.RateLimitPer10m);

        public void Execute() => ApiValidate();

        public void Execute<TServicePayload>(TServicePayload payload) where TServicePayload : class, IServicePayload =>
            Execute();

        public RiotApi GetApi() => _riotApi;

    }
}
