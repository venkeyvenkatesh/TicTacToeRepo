using System;

namespace TicTacToeGameProject
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!! Welcome to Tic Tac Toe game!");
            while (true)
            {
                TicTacToeGame tictactoe = new TicTacToeGame();
                tictactoe.startGame();

                Console.WriteLine("Do you want to play another game:(y/n)");
                char val = Convert.ToChar(Console.ReadLine());
                while(!(val.Equals('y')||val.Equals('n')))
                {
                    Console.WriteLine("Please give proper input!!");
                    Console.WriteLine("Do you want to play another game:(y/n)");
                    val = Convert.ToChar(Console.ReadLine());
                }
                if(val.Equals('n'))
                {
                    break;
                }
            }
        }
    }
}
