using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipModellingPractice
{
    public enum OccupationType
    {
        [Description("o")]
        Empty,

        [Description("X")]
        ShotFired,

        [Description("B")]
        Battleship,

        [Description("C")]
        Cruiser,

        [Description("D")]
        Destroyer,

        [Description("U")]
        Submarine,

        [Description("A")]
        Carrier,

        [Description("H")]
        Hit
    }
}
