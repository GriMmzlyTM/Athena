using Athena.Services.DependencyInjection;
using Athena.ViewModels.Application;
using Athena.ViewModels.Modules.FFXIV;
using Athena.ViewModels.Overlay;
using SimpleInjector;

namespace Athena.ViewModels
{
    /// <summary>
    /// BootstrapServices all viewmodels. Called by Entrypoint (DependencyInjectionService)
    /// </summary>
    class BootstrapViewModels : IBootstrap
    {
        public void RegisterServices(Container container)
        {
            // Main window that works as the entrypoint for the application
            container.Register<MainWindowViewModel>();

            new BootstrapApplicationViewModels()
                .RegisterServices(container);

            new BootstrapFFXIVViewModels()
                .RegisterServices(container);

            new BootstrapOverlayViewModels()
                .RegisterServices(container);
        }
    }
}
