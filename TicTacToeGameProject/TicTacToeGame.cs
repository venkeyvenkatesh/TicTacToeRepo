using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace TicTacToeGameProject
{
    class TicTacToeGame
    {
        //creating board char array
        public char[] board = new char[10];
        public char playerLetter, computerLetter;


        //starting the game
        public void startGame()
        {
            CreateBoard();
            ChooseLetter();
            Console.WriteLine("Your mark is :" + playerLetter);
            Console.WriteLine("Computer mark is :" + computerLetter);

            showBoard();
        }


        //UC1 method to create game Board
        public void CreateBoard()
        {

            for (int i = 1; i < 10; i++)
            {
                board[i] = ' ';
            }
            Console.WriteLine("Game board has been initialised.....");
        }


        //UC2 method to choose the letter by player
        public void ChooseLetter()
        {
            while (true)
            {
                Console.WriteLine("Choose either X or O");

                playerLetter = char.ToUpper(Convert.ToChar(Console.ReadLine()));

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

        //UC3 Displaying the game board
        public void showBoard()
        {
            for(int i=1;i<10;i++)
            {
                Console.Write(board[i] + "\t");
                if(i==3||i==6)
                {
                    Console.Write("\n");
                }
            }
        }

    }
}
