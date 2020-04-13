using Athena.Models.Payloads;
using Athena.ViewModels;
using SimpleInjector;

namespace Athena.Services.DependencyInjection
{
    public class DependencyInjectionService : IService
    {
        private Container _container { get; }

        public DependencyInjectionService()
        {
            _container = new Container();

            // Entrypoint for registration => Registers all services
            new BootstrapServices()
                .RegisterServices(_container);

            // Register all ViewModels
            new BootstrapViewModels()
                .RegisterServices(_container);
        }

        public T GetInstance<T>() where T : class => _container.GetInstance<T>();

        public void Execute() { }

        public void Execute<TServicePayload>(TServicePayload payload) where TServicePayload : class, IServicePayload =>
            Execute();
    }
}
