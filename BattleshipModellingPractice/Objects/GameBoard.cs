using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipModellingPractice.Objects
{
    public class GameBoard
    {
        public List<Panel> Panels { get; set; }
        public Player Player { get; set; }
    }
}
