using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Models;

namespace HomeElectronics.Services.Abstractions
{
    public interface IApartmentService
    {
        public void TurnOnRandomAppliances(int amount, IApplianceOnService applianceOnService, Appliance[] appliances);
    }
}
