using Athena.Services.DependencyInjection;
using Athena.Services.Modules.FFXIV.Create;
using SimpleInjector;

namespace Athena.Services.Modules.FFXIV
{
    public class BootstrapFFXIVModuleServices : IBootstrap
    {
        public void RegisterServices(Container container)
        {
            container.Register<IFinalFantasyXIVModuleCreateService, FinalFantasyXIVModuleCreateService>();
        }
    }
}
