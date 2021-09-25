using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Enums;

namespace HomeElectronics.Models.Appliances.RoomAppliances
{
    public abstract class Television : RoomAppliance
    {
        public abstract TelevisionType TelevisionType { get; }
        public float ScreenDiagonal { get; init; }
    }
}
