using Athena.Models.Config;
using Athena.Services.Config;
using DynamicData.Annotations;
using ReactiveUI;

namespace Athena.ViewModels
{
    public class ApplicationStatusViewModel : ViewModelBase
    {
        private string _playerWelcome;
        private bool _athenaEnabled;

        private ApplicationConfigModel _applicationConfig;
        private IApplicationConfigService _applicationConfigService { get; set; }

        public string PlayerWelcome
        {
            get => _playerWelcome;
            set => this.RaiseAndSetIfChanged(ref _playerWelcome, value);
        }

        public bool AthenaEnabled
        {
            get => _athenaEnabled;
            set => this.RaiseAndSetIfChanged(ref _athenaEnabled, value);
        }
        public ApplicationConfigModel ApplicationConfig => _applicationConfigService.GetConfig();

        public ApplicationStatusViewModel(
            IApplicationConfigService applicationConfigService)
        {
            _applicationConfigService = applicationConfigService;
            
            //PlayerWelcome = "Welcome, GriMw0lf69";
        }
    }
}
