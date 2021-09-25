using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Enums;

namespace HomeElectronics.Models.Appliances
{
    public abstract class BathroomAppliance : Appliance
    {
        public override Place Place => Place.Bathroom;
    }
}
