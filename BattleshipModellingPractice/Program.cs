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

            while(!player1.HasLost && !player2.HasLost)
            {
                var coordinates = player1.FireShot();
                var result = player2.ProcessShot(coordinates);
                player1.ProcessResult(coordinates, result);
                
                if(!player2.HasLost) //If player 2 already lost, we can't let them take another turn.
                {
                    coordinates = player2.FireShot();
                    result = player1.ProcessShot(coordinates);
                    player2.ProcessResult(coordinates, result);
                }
            }

            player1.OutputBoards();
            player2.OutputBoards();

            if(player1.HasLost)
            {
                Console.WriteLine(player2.Name + " has won the game!");
            }
            else if(player2.HasLost)
            {
                Console.WriteLine(player1.Name + " has won the game!");
            }

            Console.ReadLine();
        }
    }
}
