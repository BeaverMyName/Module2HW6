using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Models;

namespace HomeElectronics.Providers.Abstractions
{
    public interface IApplianceProvider
    {
        public Appliance[] Appliances { get; }
    }
}
