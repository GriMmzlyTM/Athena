using SimpleInjector;

namespace Athena.Services.DependencyInjection
{
    public interface IBootstrapServices
    {
        void RegisterServices(Container container);
    }
}
