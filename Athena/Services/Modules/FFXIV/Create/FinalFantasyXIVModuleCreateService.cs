using Athena.Models.Module;
using Athena.Models.Payloads.Application;
using Athena.Services.Application;
using Athena.ViewModels.Modules.FFXIV;

namespace Athena.Services.Modules.FFXIV.Create
{
    public class FinalFantasyXIVModuleCreateService : IFinalFantasyXIVModuleCreateService
    {
        private readonly ApplicationUpdateGameModulesService _applicationUpdateGameModulesService;

        public FinalFantasyXIVModuleCreateService(
            ApplicationUpdateGameModulesService applicationUpdateGameModulesService)
        {
            _applicationUpdateGameModulesService = applicationUpdateGameModulesService;
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
