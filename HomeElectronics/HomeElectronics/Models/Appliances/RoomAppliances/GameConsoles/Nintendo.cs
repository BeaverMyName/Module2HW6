using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Enums;

namespace HomeElectronics.Models.Appliances.RoomAppliances.GameConsoles
{
    public class Nintendo : GameConsole
    {
        public NintendoType NintendoType { get; init; }

        public override GameConsoleType GameConsoleType => GameConsoleType.Nintendo;
        public override Brand Brand => Brand.Nintendo;
        public override bool IsPortable => true;
    }
}
