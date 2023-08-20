using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pd_task1
{
    class Ship
    {
        public Angle latitude;
        public Angle longitude;
        public string serial_number;
        public Ship(Angle latitude, Angle longitude, string serial_number)
        {
            this.latitude = latitude;
            this.longitude = longitude;
            this.serial_number = serial_number;
        }

    }
}
