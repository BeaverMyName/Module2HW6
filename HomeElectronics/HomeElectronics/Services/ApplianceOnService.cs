using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Services.Abstractions;
using HomeElectronics.Models;
using HomeElectronics.Providers.Abstractions;

namespace HomeElectronics.Services
{
    public class ApplianceOnService : IApplianceOnService
    {
        private Appliance[] _appliances;

        public ApplianceOnService()
        {
            _appliances = new Appliance[0];
        }

        public Appliance[] Appliances => _appliances;

        public double ConsumptionPower
        {
            get
            {
                var consumptionPower = 0D;
                foreach (var appliance in _appliances)
                {
                    consumptionPower += appliance.ConsumptionPower;
                }

                return consumptionPower;
            }
        }

        public void TurnOnAppliance(Appliance appliance)
        {
            var appliances = _appliances;
            _appliances = new Appliance[appliances.Length + 1];

            for (var i = 0; i < appliances.Length; i++)
            {
                _appliances[i] = appliances[i];
            }

            _appliances[appliances.Length] = appliance;
        }

        public void TurnOffAppliance(Guid guid)
        {
            var appliances = _appliances;
            _appliances = new Appliance[appliances.Length];
            var step = 0;

            for (var i = 0; i < _appliances.Length; i++)
            {
                if (_appliances[i].Guid == guid)
                {
                    step++;
                    continue;
                }

                _appliances[i - step] = appliances[i];
            }
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(_appliances, comparer);
        }
    }
}
