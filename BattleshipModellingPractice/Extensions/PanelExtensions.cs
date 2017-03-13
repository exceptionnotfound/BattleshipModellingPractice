using BattleshipModellingPractice.Objects.Boards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipModellingPractice.Extensions
{
    public static class PanelExtensions
    {
        public static Panel At(this List<Panel> panels, int row, int column)
        {
            return panels.Where(x => x.Coordinates.Row == row && x.Coordinates.Column == column).First();
        }

        public static List<Panel> Range(this List<Panel> panels, int startRow, int startColumn, int endRow, int endColumn)
        {
            return panels.Where(x => x.Coordinates.Row >= startRow 
                                     && x.Coordinates.Column >= startColumn 
                                     && x.Coordinates.Row <= endRow 
                                     && x.Coordinates.Column <= endColumn).ToList();
        }
    }
}
