using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Enums;

namespace HomeElectronics.Models.Appliances.RoomAppliances.GameConsoles
{
    public class Xbox : GameConsole
    {
        public XboxType XboxType { get; init; }

        public override Brand Brand => Brand.Microsoft;
        public override GameConsoleType GameConsoleType => GameConsoleType.Xbox;
        public override bool IsPortable { get; }
    }
}
