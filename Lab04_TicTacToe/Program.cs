using Lab04_TicTacToe.Classes;
using System;

namespace Lab04_TicTacToe
{
   public  class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }
        /// <summary>
        /// create players and assign names,markers,turns and call the play method from the Game Class
        /// </summary>
        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Player p1 = new Player();
            Player p2 = new Player();

            p1.Marker = "X";
            Console.Write("Enter first player name :");
            p1.Name = Console.ReadLine();
            p1.IsTurn = true;

            p2.Marker = "O";
            Console.Write("Enter second player name :");
            p2.Name = Console.ReadLine();
            p2.IsTurn = false;


            Game StartGame = new Game(p1, p2);

            Player winner = StartGame.Play();
            if (winner != null)
            {
                Console.WriteLine($"The Winner is {winner.Name}");
            }
            else
            {
                Console.WriteLine("There is no Winner It's Draw");

            }
        }


    }
}
