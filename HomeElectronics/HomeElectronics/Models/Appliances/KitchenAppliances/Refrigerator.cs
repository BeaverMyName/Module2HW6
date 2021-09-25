using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeElectronics.Models.Appliances.KitchenAppliances
{
    public class Refrigerator : KitchenAppliance
    {
        public double KgCapacity { get; init; }
        public sbyte MaxTemperature { get; init; }
        public sbyte MinTemperature { get; init; }
    }
}
