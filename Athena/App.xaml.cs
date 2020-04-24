using Athena.Services;
using Athena.Services.Config;
using Athena.Services.DependencyInjection;
using Athena.Services.Modules;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Athena.ViewModels;
using Athena.Views;

namespace Athena
{
    public class App : Application
    {
        private DependencyInjectionService dependencyInjectionService { get; set; }

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            base.OnFrameworkInitializationCompleted();

            if (!(ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)) return;

            dependencyInjectionService = new DependencyInjectionService();

            dependencyInjectionService.GetInstance<ApplicationUpdateConfigService>().Execute();
            dependencyInjectionService.GetInstance<IModulesInitializationService>().Execute();

            desktop.MainWindow = new MainWindow
            {
                DataContext = dependencyInjectionService.GetInstance<MainWindowViewModel>(),
            };

        }
    }
}
