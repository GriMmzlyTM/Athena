using Athena.Models.Application;
using Athena.Models.Config;
using Avalonia.Controls;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Reactive;

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

        private ViewModelBase _moduleSettings;

        public ViewModelBase ModuleSettings
        {
            get => _moduleSettings;
            set => this.RaiseAndSetIfChanged(ref _moduleSettings, value);
        }

        public ReactiveCommand<ViewModelBase, Unit> RunUpdateSettings { get; }

        public ApplicationHomeViewModel(
            ApplicationConfigModel applicationConfigModel,
            ApplicationGameModulesListModel gameModulesList)
        {
            _gameModulesList = gameModulesList;
            _applicationConfigModel = applicationConfigModel;
            RunUpdateSettings = ReactiveCommand.Create<ViewModelBase>(UpdateSettings);
            foreach (var module in gameModulesList.Modules)
            {
                GameOptionButtons.Add(new Button()
                {
                    Content = module.Value.Name,
                    CommandParameter = (ViewModelBase)Activator.CreateInstance(module.Value.SettingsViewModel),
                    Command = RunUpdateSettings,
                    Height = 30
                });
            }
        }

        public void UpdateSettings(ViewModelBase view)
        {
            ModuleSettings = view;
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
