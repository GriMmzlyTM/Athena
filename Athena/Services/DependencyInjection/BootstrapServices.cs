
using System;
using Athena.Services.Config;
using Athena.Services.Riot;
using SimpleInjector;

namespace Athena.Services.DependencyInjection
{
    /// <summary>
    /// Entrypoint for registering all services available for dependency injection
    /// Add bootstrap files here. 
    /// </summary>
    public class BootstrapServices : IBootstrapServices
    { 
        public void RegisterServices(Container container)
        {
            // Configuration management
            var bootstrapConfig = new BootstrapConfig();
            bootstrapConfig.RegisterServices(container);

            // Riot API 
            var bootstrapRiot = new BootstrapRiot();
            bootstrapRiot.RegisterServices(container);
        }
    }
}
