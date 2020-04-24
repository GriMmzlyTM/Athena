using System.Collections.Generic;
using System.Reactive;
using System.Runtime.CompilerServices;
using Athena.Models.Account;
using Athena.Models.Application;
using Athena.Models.Config;
using Athena.Models.Payloads.Riot.Account;
using Athena.Services.Riot.Account;
using Avalonia.Controls;
using ReactiveUI;
using RiotSharp.Misc;

namespace Athena.ViewModels.Application
{
    public class ApplicationHomeViewModel : ViewModelBase
    {
        private readonly ApplicationGameModulesListModel _gameModulesList;
        private ApplicationConfigModel _applicationConfigModel { get; }
        public ViewConfigModel HomeViewConfig => _applicationConfigModel.HomeView;
        private List<Button> _gameOptionButtons = new List<Button>();

        public List<Button> GameOptionButtons
        {
            get => _gameOptionButtons;
            set => this.RaiseAndSetIfChanged(ref _gameOptionButtons, value);
        }

        public ApplicationHomeViewModel(
            ApplicationConfigModel applicationConfigModel,
            ApplicationGameModulesListModel gameModulesList)
        {
            _gameModulesList = gameModulesList;
            _applicationConfigModel = applicationConfigModel;
            foreach (var module in gameModulesList.Modules)
            {
                GameOptionButtons.Add(new Button()
                {
                    Content = module.Value.Name,
                    Height = 30
                });
            }
        }
        /*
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
        }*/
    }
}
