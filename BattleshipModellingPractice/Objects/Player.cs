using BattleshipModellingPractice.Extensions;
using BattleshipModellingPractice.Objects.Boards;
using BattleshipModellingPractice.Objects.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipModellingPractice.Objects
{
    public class Player
    {
        public string Name { get; set; }
        public PlayerBoard OwnBoard { get; set; }
        public FiringBoard FiringBoard { get; set; }
        public List<Ship> Ships { get; set; }

        public Player(string name)
        {
            Name = name;
            Ships = new List<Ship>()
            {
                new Destroyer(),
                new Submarine(),
                new Cruiser(),
                new Battleship(),
                new Carrier()
            };
            OwnBoard = new PlayerBoard();
            FiringBoard = new FiringBoard();
        }

        public void OutputBoards()
        {
            Console.WriteLine(Name + "'s Own Board:                " + Name + "'s Firing Board:");
            for(int row = 1; row <= 10; row++)
            {
                for(int ownColumn = 1; ownColumn <= 10; ownColumn++)
                {
                    Console.Write(OwnBoard.Panels.At(row, ownColumn).Status + " ");
                }
                Console.Write("                ");
                for (int firingColumn = 1; firingColumn <= 10; firingColumn++)
                {
                    Console.Write(FiringBoard.Panels.At(row, firingColumn).Status + " ");
                }
                Console.WriteLine(Environment.NewLine);
            }
            Console.WriteLine(Environment.NewLine);
        }

        public void PlaceShips()
        {
            //Random class creation stolen from http://stackoverflow.com/a/18267477/106356
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            foreach (var ship in Ships)
            {
                //Select a random row/column combination, then select a random orientation.
                //If none of the proposed panels are occupied, place the ship
                //Do this for all ships

                bool isOpen = true;
                while (isOpen)
                {
                    var startcolumn = rand.Next(1,10);
                    var startrow = rand.Next(1, 10);
                    int endrow = startrow, endcolumn = startcolumn;
                    var orientation = rand.Next(1, 100) % 2; //0 for Horizontal

                    List<int> panelNumbers = new List<int>();
                    if (orientation == 0)
                    {
                        for (int i = 1; i < ship.Width; i++)
                        {
                            endrow++;
                        }
                    }
                    else
                    {
                        for (int i = 1; i < ship.Width; i++)
                        {
                            endcolumn++;
                        }
                    }

                    if(endrow < 1 || endrow > 10 || endcolumn < 1 || endcolumn > 10)
                    {
                        isOpen = true;
                        continue;
                    }

                    //Check if specified panels are occupied
                    var affectedPanels = OwnBoard.Panels.Range(startrow, startcolumn, endrow, endcolumn);
                    if(affectedPanels.Any(x=>x.IsOccupied))
                    {
                        isOpen = true;
                        continue;
                    }

                    foreach(var panel in affectedPanels)
                    {
                        panel.OccupationType = ship.OccupationType;
                    }
                    isOpen = false;
                }
            }
        }
    }
}
