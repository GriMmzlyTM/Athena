using Athena.Models.Module;
using Athena.Models.Payloads.Application;
using Athena.Services.Application;
using Athena.ViewModels.Modules.FFXIV;

namespace Athena.Services.Modules.FFXIV.Create
{
    public class FinalFantasyXIVModuleCreateService : IFinalFantasyXIVModuleCreateService
    {
        private readonly ApplicationUpdateGameModulesService _applicationUpdateGameModulesService;
        private readonly FinalFantasyXIVSettingsViewModel _finalFantasyXivSettingsViewModel;

        public FinalFantasyXIVModuleCreateService(
            ApplicationUpdateGameModulesService applicationUpdateGameModulesService,
            FinalFantasyXIVSettingsViewModel finalFantasyXivSettingsViewModel)
        {
            _applicationUpdateGameModulesService = applicationUpdateGameModulesService;
            _finalFantasyXivSettingsViewModel = finalFantasyXivSettingsViewModel;
        }
        public void Execute()
        {
            var module = new GameModuleModel()
            {
                Name = "Final Fantasy XIV",
                SettingsViewModel = typeof(FinalFantasyXIVSettingsViewModel)
            };

            _applicationUpdateGameModulesService.Execute(
                new ApplicationUpdateGameModulesPayload()
                {
                    Module = module
                });
        }
    }
}
