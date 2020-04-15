using Athena.Services.Config;
using Athena.Services.Riot;
using SimpleInjector;

namespace Athena.Services.DependencyInjection
{
    /// <summary>
    /// Entrypoint for registering all services available for dependency injection
    /// Add bootstrap files here. 
    /// </summary>
    public class Bootstrap : IBootstrap
    { 
        public void RegisterServices(Container container)
        {
            // Configuration management
            new BootstrapConfig()
                .RegisterServices(container);

            // Riot API 
            new BootstrapRiot()
                .RegisterServices(container);
        }
    }
}
