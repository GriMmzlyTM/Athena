using System;
using System.Collections.Generic;
using System.Text;
using Athena.Services.DependencyInjection;
using SimpleInjector;

namespace Athena.ViewModels.Application
{
    /// <summary>
    /// Register ViewModels related to core application logic. Not for overlays or popups. 
    /// </summary>
    class BootstrapApplicationViewModels : IBootstrapServices
    {
        public void RegisterServices(Container container)
        {
            container.Register<ApplicationStatusViewModel>();
        }
    }
}
