using Athena.Services.DependencyInjection;
using SimpleInjector;

namespace Athena.ViewModels.Application
{
    /// <summary>
    /// Register ViewModels related to core application logic. Not for overlays or popups. 
    /// </summary>
    class BootstrapApplicationViewModels : IBootstrap
    {
        public void RegisterServices(Container container)
        {
            container.Register<ApplicationSettingsViewModel>();
            container.Register<ApplicationHomeViewModel>();
        }
    }
}
