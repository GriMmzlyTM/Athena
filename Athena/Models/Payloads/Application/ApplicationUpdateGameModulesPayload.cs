using System;
using System.Collections.Generic;
using System.Text;
using Athena.Models.Module;

namespace Athena.Models.Payloads.Application
{
    public class ApplicationUpdateGameModulesPayload : IServicePayload
    {
        public GameModuleModel Module { get; set; }
    }
}
