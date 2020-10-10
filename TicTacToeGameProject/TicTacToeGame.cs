using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TicTacToeGameProject
{
    class TicTacToeGame
    {
        //creating board char array
        public char[] board=new char[10];
        public char playerLetter, computerLetter;

        public void startGame()
        {
            CreateBoard();
            ChooseLetter();
            Console.WriteLine("Your mark is :" + playerLetter);
            Console.WriteLine("Computer mark is :" + computerLetter);
        }
        //method to create game Board
        public void CreateBoard()
        {
           
            for (int i=1;i<10;i++)
            {
                board[i] = Convert.ToChar('0');
            }
        }

        public void ChooseLetter()
        {
            while (true)
            {
                Console.WriteLine("Choose either X or O");

                playerLetter = Convert.ToChar(Console.ReadLine());

                if (playerLetter.Equals('X') || playerLetter.Equals('O'))
                {
                    break;
                }
            }
            if (playerLetter.Equals('X'))
            {
               computerLetter = 'O';
            }
            else
            {
                computerLetter = 'X';
            }

        }

    }
}
