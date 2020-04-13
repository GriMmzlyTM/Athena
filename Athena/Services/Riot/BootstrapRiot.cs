using Athena.Services.DependencyInjection;
using Athena.Services.Riot.Account;
using SimpleInjector;

namespace Athena.Services.Riot
{
    /// <summary>
    /// Register riot API services
    /// </summary>
    public class BootstrapRiot : IBootstrapServices
    {
        public void RegisterServices(Container container)
        {
            // Riot Account services
            new BootstrapRiotAPIAccount()
                .RegisterServices(container);
        }
    }
}
