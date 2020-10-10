using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGameProject
{
    class TicTacToeGame
    {
        //creating board char array
        public char[] board;

        //method to create game Board
        public void CreateBoard()
        {
            board = new char[10];
            for (int i=1;i<10;i++)
            {
                board[i] = Convert.ToChar('0');
            }
        }
    }
}
