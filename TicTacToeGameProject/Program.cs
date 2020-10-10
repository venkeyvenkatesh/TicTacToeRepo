using System;

namespace TicTacToeGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!! Welcome to Tic Tac Toe game!");

            TicTacToeGame tictactoe = new TicTacToeGame();
           tictactoe.startGame();
        }
    }
}
