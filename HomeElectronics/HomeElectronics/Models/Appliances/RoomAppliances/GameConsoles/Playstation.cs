using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Enums;

namespace HomeElectronics.Models.Appliances.RoomAppliances.GameConsoles
{
    public class Playstation : GameConsole
    {
        public PlaystationType PlaystationType { get; init; }

        public override Brand Brand => Brand.Sony;
        public override GameConsoleType GameConsoleType => GameConsoleType.Playstation;
        public override bool IsPortable { get; }
    }
}
