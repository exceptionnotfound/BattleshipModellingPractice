using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipModellingPractice.Objects.Ships
{
    public class Cruiser : Ship
    {
        public Cruiser()
        {
            Width = 3;
            OccupationType = OccupationType.Cruiser;
        }
    }
}
