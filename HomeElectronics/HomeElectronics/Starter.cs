using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using HomeElectronics.Services;
using HomeElectronics.Services.Abstractions;
using HomeElectronics.Providers;
using HomeElectronics.Providers.Abstractions;

namespace HomeElectronics
{
    public class Starter
    {
        public void StartAppliacation()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IApartmentService, ApartmentService>()
                .AddTransient<IApplianceOnService, ApplianceOnService>()
                .AddTransient<IApplianceProvider, ApplianceProvider>()
                .AddTransient<Application>()
                .BuildServiceProvider();

            var application = serviceProvider.GetService<Application>();
            application.Run();
        }
    }
}
