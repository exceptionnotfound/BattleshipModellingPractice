using BattleshipModellingPractice.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipModellingPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Player1");
            Player player2 = new Player("Player2");

            player1.PlaceShips();
            player2.PlaceShips();

            player1.OutputBoards();
            player2.OutputBoards();

            Console.ReadLine();
        }
    }
}
