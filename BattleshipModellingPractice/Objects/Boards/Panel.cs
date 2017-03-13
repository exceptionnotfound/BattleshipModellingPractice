using BattleshipModellingPractice.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipModellingPractice.Objects.Boards
{
    public class Panel
    {
        public OccupationType OccupationType { get; set; }
        public int RowID { get; set; }
        public int ColumnID { get; set; }

        public Panel(int row, int column)
        {
            RowID = row;
            ColumnID = column;
        }

        public string Status
        {
            get
            {
                return OccupationType.GetAttributeOfType<DescriptionAttribute>().Description;
            }
        }

        public bool IsOccupied
        {
            get
            {
                return OccupationType == OccupationType.Battleship
                    || OccupationType == OccupationType.Destroyer
                    || OccupationType == OccupationType.Cruiser
                    || OccupationType == OccupationType.Submarine
                    || OccupationType == OccupationType.Carrier;
            }
        }
    }
}
