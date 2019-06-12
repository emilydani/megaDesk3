using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3
{
    class Desk
    {
        public int width { get; set;}
        public int depth { get; set; }
        public int numOfDrawers { get; set; }
        public enum DesktopMaterial {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        };

        public string material { get; set; }

        public int size { get; set; }
    }
}
