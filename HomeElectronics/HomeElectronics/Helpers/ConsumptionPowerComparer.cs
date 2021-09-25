using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Models;

namespace HomeElectronics.Helpers
{
    public class ConsumptionPowerComparer : IComparer
    {
        public int Compare(object obj1, object obj2)
        {
            var appliance1 = obj1 as Appliance;
            var appliance2 = obj2 as Appliance;

            if (appliance1.ConsumptionPower > appliance2.ConsumptionPower)
            {
                return 1;
            }
            else if (appliance1.ConsumptionPower < appliance2.ConsumptionPower)
            {
                return -1;
            }

            return 0;
        }
    }
}
