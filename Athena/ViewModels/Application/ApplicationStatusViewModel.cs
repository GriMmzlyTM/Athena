using System.Reactive;
using Athena.Models.Account;
using Athena.Models.Config;
using Athena.Models.Payloads.Riot.Account;
using Athena.Services.Riot.Account;
using ReactiveUI;
using RiotSharp.Misc;

namespace Athena.ViewModels.Application
{
    public class ApplicationStatusViewModel : ViewModelBase
    {
        private readonly RiotAccountModel _riotAccountModel;
        private readonly IRiotAPIAccountGetService _riotApiAccountGet;
        private string _playerWelcome;
        private bool _athenaEnabled;

        public ReactiveCommand<string, Unit> UpdateSummonerCommand { get; }

        private ApplicationConfigModel _applicationConfigModel { get; }

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

        public ApplicationStatusViewModel(
            ApplicationConfigModel applicationConfigModel,
            RiotAccountModel riotAccountModel,
            IRiotAPIAccountGetService riotApiAccountGet)
        {
            _riotAccountModel = riotAccountModel;
            _riotApiAccountGet = riotApiAccountGet;
            _applicationConfigModel = applicationConfigModel;

            UpdateSummonerCommand = ReactiveCommand.Create<string>(UpdateSummoner);

            if(_riotAccountModel.Summoner != null)
                _playerWelcome = $"Welcome, {_riotAccountModel.Summoner.Name} | CURRENTLY IN {_applicationConfigModel.Environment}";
        }

        public void UpdateSummoner(string summonerName)
        {
            _riotApiAccountGet.Execute(new RiotAPIAccountPayload
            {
                AccountName = summonerName,
                AccountRegion = Region.Na
            });

            PlayerWelcome = $"Welcome, {_riotAccountModel.Summoner.Name} \n" +
                            $"CURRENTLY IN {_applicationConfigModel.Environment} \n" +
                            $"Level: {_riotAccountModel.Summoner.Level}";
        }
    }
}
