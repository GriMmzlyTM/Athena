using SimpleInjector;

namespace Athena.Services.DependencyInjection
{
    public interface IBootstrap
    {
        void RegisterServices(Container container);
    }
}
