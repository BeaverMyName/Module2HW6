using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Enums;

namespace HomeElectronics.Models
{
    public abstract class Appliance
    {
        public Appliance()
        {
            Guid = Guid.NewGuid();
        }

        public Guid Guid { get; }
        public double Price { get; init; }
        public Currency Currency { get; init; }
        public double Weight { get; init; }
        public double ConsumptionPower { get; init; }
        public virtual Brand Brand { get; init; }
        public abstract Place Place { get; }
    }
}
