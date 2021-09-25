using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Models;
using HomeElectronics.Models.Appliances.BathroomAppliances;
using HomeElectronics.Models.Appliances.KitchenAppliances;
using HomeElectronics.Models.Appliances.RoomAppliances.GameConsoles;
using HomeElectronics.Models.Appliances.RoomAppliances.Televisions;
using HomeElectronics.Providers.Abstractions;
using HomeElectronics.Enums;

namespace HomeElectronics.Providers
{
    public class ApplianceProvider : IApplianceProvider
    {
        private readonly Appliance[] _appliance;

        public ApplianceProvider()
        {
            _appliance = new Appliance[]
            {
                new LEDTelevision() { Brand = Brand.Samsung, Currency = Currency.USD, Price = 1000, ScreenDiagonal = 43, Weight = 25, ConsumptionPower = 22.5 },
                new Xbox() { Currency = Currency.USD, Price = 500, XboxType = XboxType.SeriesX, Weight = 3, ConsumptionPower = 5 },
                new Boiler() { Currency = Currency.USD, Price = 200, Volume = 80, Weight = 40, ConsumptionPower = 48.5 },
                new WashingMachine() { Currency = Currency.USD, Price = 300, RPM = 1700, Weight = 60, ConsumptionPower = 25.5 },
                new Microwave() { Currency = Currency.UAH, Price = 3000, WattPower = 1600, Weight = 10, ConsumptionPower = 11.25 },
                new Refrigerator() { Currency = Currency.USD, Price = 400, KgCapacity = 110, MaxTemperature = 10, MinTemperature = -40, Weight = 90, ConsumptionPower = 28.8 }
            };
        }

        public Appliance[] Appliances => _appliance;
    }
}
