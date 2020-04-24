using System.Collections.Generic;
using Athena.Services.Modules.FFXIV.Create;

namespace Athena.Services.Modules
{
    public class ModulesInitializationService : IModulesInitializationService
    {

        private List<IService> _createServices = new List<IService>();

        public ModulesInitializationService(
            IFinalFantasyXIVModuleCreateService finalFantasyXIVModuleCreateService)
        {
            _createServices.Add(finalFantasyXIVModuleCreateService);
        }

        public void Execute()
        {
            foreach (var service in _createServices)
            {
                service.Execute();
            }
        }
    }
}
