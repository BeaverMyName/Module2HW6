using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Enums;

namespace HomeElectronics.Models.Appliances.RoomAppliances
{
    public abstract class GameConsole : RoomAppliance
    {
        public abstract GameConsoleType GameConsoleType { get; }
        public abstract bool IsPortable { get; }
    }
}
