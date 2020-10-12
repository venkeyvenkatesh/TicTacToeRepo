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
        char startingMove;

        //starting the game
        public void startGame()
        {
            CreateBoard();
            ChooseLetter();
            Console.WriteLine("Your mark is :" + playerLetter);
            Console.WriteLine("Computer mark is :" + computerLetter);

            showBoard();
            startingMove = whoStartsFirst();

            while(!CheckWonOrNot(startingMove))
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

            if (!(position >= 1 && position < 10))
            {
                Console.WriteLine("Invalid position selected ");
                MakeAMove();
            }
            else
            {
                while (!(AvailabilityChecker(position)))
                {
                    Console.WriteLine("The place is already filled ...fill another one");
                    Console.WriteLine("player 1 !! Enter your position to mark");
                    position = Convert.ToInt32(Console.ReadLine());
                }
                board[position] = playerLetter;
                showBoard();
            }
        }

        public bool AvailabilityChecker(int position)
        {
            bool temp = false;
            if (board[position].Equals(' '))
            {
                temp = true;
            }
            return temp;
        }


       //UC6 who plays first
        public char whoStartsFirst()
        {
            Random random = new Random();
            int toss = random.Next(1, 3);
            
            Console.WriteLine("Choose Heads(0) or Tails(1)");
            int choose = Convert.ToInt32(Console.ReadLine());
            while (!(choose == 1 || choose == 0))
            {
             
                Console.WriteLine("Choose Heads(0) or Tails(1)");
                choose = Convert.ToInt32(Console.ReadLine());
            }

            
            if (choose == toss)
            {
                Console.WriteLine("Player starts first");
                return playerLetter;
            }
            else
            {
                Console.WriteLine("Computer starts first");
                return computerLetter;
            }
        }


        //UC7 whether someone won or not
        public bool CheckWonOrNot(char player)
        {
            bool won = false;
            if (board[1].Equals(player) && board[5].Equals(player) && board[9].Equals(player))
            {
                won = true;
            }
            if (board[3].Equals(player) && board[5].Equals(player) && board[7].Equals(player))
            {
                won = true;
            }
            for (int i = 1; i < 10;)
            {
                if (board[i].Equals(player) && board[i + 1].Equals(player) && board[i + 2].Equals(player))
                {
                    won = true;
                }
                i = i + 3;
            }
            for (int i = 1; i < 4; i++)

            {
                if (board[i].Equals(player) && board[i + 3].Equals(player) && board[i + 6].Equals(player))
                {
                    won = true;
                }

            }
            return won;
        }


    }
}
