using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Services.Abstractions;
using HomeElectronics.Providers.Abstractions;
using HomeElectronics.Helpers;
using HomeElectronics.Extensions;
using HomeElectronics.Models.Appliances.RoomAppliances.GameConsoles;

namespace HomeElectronics
{
    public class Application
    {
        private readonly IApplianceOnService _applianceOnService;
        private readonly IApplianceProvider _applianceProvider;
        private readonly IApartmentService _apartmentService;

        public Application(IApplianceOnService applianceOnService, IApplianceProvider applianceProvider, IApartmentService apartmentService)
        {
            _applianceOnService = applianceOnService;
            _applianceProvider = applianceProvider;
            _apartmentService = apartmentService;
        }

        public void Run()
        {
            _apartmentService.TurnOnRandomAppliances(5, _applianceOnService, _applianceProvider.Appliances);
            var consumptionPower = _applianceOnService.ConsumptionPower;
            _applianceOnService.Sort(new ConsumptionPowerComparer());
            var appliance = _applianceOnService.Appliances.FindSpecificAppliance(typeof(Xbox));
        }
    }
}
