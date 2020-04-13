using Athena.Models.Config;
using Athena.Services.DependencyInjection;
using SimpleInjector;

namespace Athena.Services.Config
{
    /// <summary>
    /// Register configuration services (AthenaConfig.yml etc)
    /// </summary>
    class BootstrapConfig : IBootstrapServices
    {
        public void RegisterServices(Container container)
        {

            container.Register<ApplicationConfigModel>(Lifestyle.Singleton);
            container.Register<IApplicationUpdateConfigService, ApplicationUpdateConfigService>();
        }
    }
}
