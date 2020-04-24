using Athena.Models.Application;
using Athena.Models.Payloads.Application;
using System;

namespace Athena.Services.Application
{
    /// <summary>
    /// Updates <see cref="ApplicationGameModulesListModel"/> containing data requires to display manage and use game modules
    /// </summary>
    public class ApplicationUpdateGameModulesService : IApplicationUpdateGameModulesService
    {
        private readonly ApplicationGameModulesListModel _applicationGameModulesModel;

        public ApplicationUpdateGameModulesService(
            ApplicationGameModulesListModel applicationGameModulesModel)
        {
            _applicationGameModulesModel = applicationGameModulesModel;
        }

        public void Execute(ApplicationUpdateGameModulesPayload payload)
        {
            var module = payload as ApplicationUpdateGameModulesPayload
                         ?? throw new NullReferenceException("ApplicationUpdateGameModulesPayload is null");
            _applicationGameModulesModel.Modules[module.Module.Name] = module.Module;
        }
    }
}
