using Athena.ViewModels;
using SimpleInjector;

namespace Athena.Services.DependencyInjection
{
    public class DependencyInjectionService
    {
        private Container _container { get; }

        public DependencyInjectionService()
        {
            _container = new Container();

            // Entrypoint for registration => Registers all services
            var bootstrapServices = new BootstrapServices();
            bootstrapServices.RegisterServices(_container);

            var bootstrapViewModels = new BootstrapViewModels();
            bootstrapViewModels.RegisterServices(_container);
        }

        public T GetInstance<T>() where T : class => _container.GetInstance<T>();

    }
}
