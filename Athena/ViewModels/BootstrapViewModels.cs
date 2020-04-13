using Athena.Services.DependencyInjection;
using Athena.ViewModels.Application;
using SimpleInjector;

namespace Athena.ViewModels
{
    /// <summary>
    /// Bootstrap all viewmodels. Called by Entrypoint (DependencyInjectionService)
    /// </summary>
    class BootstrapViewModels : IBootstrapServices
    {
        public void RegisterServices(Container container)
        {
            // Main window that works as the entrypoint for the application
            container.Register<MainWindowViewModel>();

            new BootstrapApplicationViewModels()
                .RegisterServices(container);
        }
    }
}
