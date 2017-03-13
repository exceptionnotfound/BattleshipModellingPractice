using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipModellingPractice.Objects.Ships
{
    public class Destroyer : Ship
    {
        public Destroyer()
        {
            Width = 2;
            OccupationType = OccupationType.Destroyer;
        }
    }
}
