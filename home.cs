using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    class home
    {
        private int id;
        private String name;
        private String zone;
        private String status;
        private int place;
        private int x;
        private int y;

        public home(string name, string zone, string status, int place, int x, int y)
        {
            this.name = name;
            this.zone = zone;
            this.status = status;
            this.place = place;
            this.x = x;
            this.y = y;
        }

        public home(int id, string name, string zone, string status, int place, int x, int y)
        {
            this.id = id;
            this.name = name;
            this.zone = zone;
            this.status = status;
            this.place = place;
            this.x = x;
            this.y = y;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Zone { get => zone; set => zone = value; }
        public int Place { get => place; set => place = value; }
        public string Status { get => status; set => status = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
}
