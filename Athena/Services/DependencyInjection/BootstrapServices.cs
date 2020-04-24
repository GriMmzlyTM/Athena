using Athena.Services.Application;
using Athena.Services.Config;
using Athena.Services.Modules;
using Athena.Services.Modules.FFXIV;
using Athena.Services.Riot;
using SimpleInjector;

namespace Athena.Services.DependencyInjection
{
    /// <summary>
    /// Entrypoint for registering all services available for dependency injection
    /// Add bootstrap files here. 
    /// </summary>
    public class BootstrapServices : IBootstrap
    { 
        public void RegisterServices(Container container)
        {
            // Configuration management
            new BootstrapConfig()
                .RegisterServices(container);
            // Application
            new BootstrapApplication()
                .RegisterServices(container);
            // Riot API 
            new BootstrapRiot()
                .RegisterServices(container);
            // FFXIV module
            new BootstrapModules()
                .RegisterServices(container);
        }
    }
}
