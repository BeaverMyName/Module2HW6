using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Enums;

namespace HomeElectronics.Models.Appliances.RoomAppliances.Televisions
{
    public class LEDTelevision : Television
    {
        public override TelevisionType TelevisionType => TelevisionType.LED;
    }
}
