using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Models;

namespace HomeElectronics.Services.Abstractions
{
    public interface IApplianceOnService
    {
        public Appliance[] Appliances { get; }
        public double ConsumptionPower { get; }
        public void TurnOnAppliance(Appliance appliance);
        public void TurnOffAppliance(Guid guid);
        public void Sort(IComparer comparer);
    }
}
