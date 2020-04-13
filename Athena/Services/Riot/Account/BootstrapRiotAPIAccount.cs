using Athena.Models.Account;
using Athena.Services.DependencyInjection;
using SimpleInjector;

namespace Athena.Services.Riot.Account
{
    public class BootstrapRiotAPIAccount : IBootstrapServices
    {
        public void RegisterServices(Container container)
        {
            container.Register<RiotAccountModel>(Lifestyle.Singleton);
            container.Register<RiotAPIService>(Lifestyle.Singleton);
            container.Register<IRiotAPIAccountGetService, RiotAPIAccountGetService>();
        }
    }
}
