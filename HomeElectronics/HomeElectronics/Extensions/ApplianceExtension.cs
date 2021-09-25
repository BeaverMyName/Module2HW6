using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Models;

namespace HomeElectronics.Extensions
{
    public static class ApplianceExtension
    {
        public static Appliance FindSpecificAppliance(this Appliance[] appliances, Type type)
        {
            foreach (var appliance in appliances)
            {
                if (appliance.GetType() == type)
                {
                    return appliance;
                }
            }

            return null;
        }
    }
}
