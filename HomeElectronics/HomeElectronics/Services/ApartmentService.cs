using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Services.Abstractions;
using HomeElectronics.Models;

namespace HomeElectronics.Services
{
    public class ApartmentService : IApartmentService
    {
        public void TurnOnRandomAppliances(int amount, IApplianceOnService applianceOnService, Appliance[] appliances)
        {
            var random = new Random();

            for (var i = 0; i < amount; i++)
            {
                applianceOnService.TurnOnAppliance(appliances[random.Next(appliances.Length)]);
            }
        }
    }
}
