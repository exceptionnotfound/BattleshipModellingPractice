using BattleshipModellingPractice.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipModellingPractice.Objects.Boards
{
    public class FiringBoard : GameBoard
    {
        public void MarkExcludedPanels()
        {
            var panels = Panels.Where(x => x.OccupationType == OccupationType.Empty);
            foreach (var panel in panels)
            {
                var neighbors = GetNeighbors(panel.Coordinates);
                if (neighbors.All(x => x.OccupationType == OccupationType.Miss))
                {
                    panel.OccupationType = OccupationType.Excluded;
                }
            }
        }

        public List<Coordinates> GetOpenRandomPanels()
        {
            return Panels.Where(x => x.OccupationType == OccupationType.Empty && x.IsRandomAvailable).Select(x=>x.Coordinates).ToList();
        }

        public List<Coordinates> GetHitNeighbors()
        {
            List<Panel> panels = new List<Panel>();
            var hits = Panels.Where(x => x.OccupationType == OccupationType.Hit);
            foreach(var hit in hits)
            {
                panels.AddRange(GetNeighbors(hit.Coordinates).ToList());
            }
            return panels.Distinct().Where(x => x.OccupationType == OccupationType.Empty).Select(x => x.Coordinates).ToList();
        }
    }
}
