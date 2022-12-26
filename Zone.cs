using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    internal class Zone
    {
        private int id;
        private string nameZone;
        private int xzone;
        private int yzone;
        private int location_y;
        private int location_x;



        public Zone(int id, string nameZone, int xzone, int yzone, int location_x,int location_y)
        {
            this.id = id;
            this.nameZone = nameZone;
            this.xzone = xzone;
            this.yzone = yzone;
            this.Location_x = location_x;
            this.Location_y = location_y;
        }

        public Zone( string nameZone, int xzone, int yzone, int location_x, int location_y)
        {
            this.nameZone = nameZone;
            this.xzone = xzone;
            this.yzone = yzone;
            this.Location_x = location_x;
            this.Location_y = location_y;
        }
        public int Id { get => id; set => id = value; }
        public string NameZone { get => nameZone; set => nameZone = value; }
        public int Xzone { get => xzone; set => xzone = value; }
        public int Yzone { get => yzone; set => yzone = value; }
        public int Location_y { get => location_y; set => location_y = value; }
        public int Location_x { get => location_x; set => location_x = value; }
    }
}
