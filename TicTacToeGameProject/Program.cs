using System;

namespace TicTacToeGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!! Welcome to Tic Tac Toe game!");

            TicTacToeGame game = new TicTacToeGame();
            game.CreateBoard();
        }
    }
}
