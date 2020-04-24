using System;
using System.Collections.Generic;
using System.Text;
using Athena.Services.DependencyInjection;
using SimpleInjector;

namespace Athena.ViewModels.Overlay
{
    public class BootstrapOverlayViewModels : IBootstrap    
    {
        public void RegisterServices(Container container)
        {
            container.Register<OverlayViewModel>();
        }
    }
}
