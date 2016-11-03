using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipModellingPractice.Objects
{
    public class Panel
    {
        public int Column { get; set; }
        public int Row { get; set; }
        public bool IsOccupied { get; set; }
        public bool IsShot { get; set; }
    }
}
