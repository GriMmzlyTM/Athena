using System;
using System.Collections.Generic;
using System.Text;
using Athena.Services.DependencyInjection;
using SimpleInjector;

namespace Athena.Services.Config
{
    class BootstrapConfig : IBootstrapServices
    {
        public void RegisterServices(Container container)
        {
            container.Register<IApplicationConfigService, ApplicationConfigService>(Lifestyle.Singleton);
        }
    }
}
