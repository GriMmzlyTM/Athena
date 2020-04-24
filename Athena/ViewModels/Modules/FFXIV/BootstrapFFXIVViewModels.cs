using Athena.Services.DependencyInjection;
using SimpleInjector;

namespace Athena.ViewModels.Modules.FFXIV
{
    public class BootstrapFFXIVViewModels : IBootstrap
    {
        public void RegisterServices(Container container)
        {
            container.Register<FinalFantasyXIVSettingsViewModel>();
        }
    }
}
