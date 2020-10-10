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
            while(true)
            {
                MakeAMove();
            }

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
                    if (playerLetter.Equals('X'))
                    {
                        computerLetter = 'O';
                    }
                    else
                    {
                        computerLetter = 'X';
                    }
                    break;
                }
            }



        }

        //UC3 Displaying the game board
        public void showBoard()
        {


            Console.WriteLine("\n " + board[1] + " | " + board[2] + " | " + board[3]);

            Console.WriteLine("-----------");
            Console.WriteLine("\n " + board[4] + " | " + board[5] + " | " + board[6]);

            Console.WriteLine("------------");
            Console.WriteLine("\n " + board[7] + " | " + board[8] + " | " + board[9]);



        }

        //UC4 making a move
        public void MakeAMove()
        {
            Console.WriteLine("Enter your position to mark");
            int position = Convert.ToInt32(Console.ReadLine());
            
            while (!(checkAvailability(position)))
            {
                Console.WriteLine("The place is already filled ...fill another one");
                Console.WriteLine("player 1 !! Enter your position to mark");
                position = Convert.ToInt32(Console.ReadLine());
            }
            board[position] = playerLetter;
            showBoard();
        }

        public bool checkAvailability(int position)
        {
            bool val = false;
            if (board[position].Equals(' '))
            {
                val = true;
            }
            return val;
        }
    }
}