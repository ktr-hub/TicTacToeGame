using System;
using System.Dynamic;
using System.Net;
using System.Threading.Channels;

namespace TicTocToe
{
    class TicTacToeGame
    {
        static void Main(string[] args)
        {
            char[] positions = UC1_createBoard();
            char playerLetter = UC2_getPlayerLetter();
            char computerLetter = getComputerLetter(playerLetter);
            UC3_showBoard(positions);
            UC5_makeAMove(positions, playerLetter);
            UC3_showBoard(positions);
        }
        public static char[] UC1_createBoard()
        {
            char[] positions = new char[10];
            for (int i = 1; i < 10; i++)
            {
                positions[i] = ' ';
            }
            return positions;
        }

        public static char UC2_getPlayerLetter()
        {
            while (true)
            {
                Console.Write("Please enter your letter(X or O) : ");
                try
                {
                    char playerLetter;
                    char inputLetter = Convert.ToChar(Console.ReadLine());

                    if (inputLetter == 'X' || inputLetter == 'x')
                    {
                        playerLetter = 'X';
                        return playerLetter;
                    }
                    else if (inputLetter == 'O' || inputLetter == 'o')
                    {
                        playerLetter = 'O';
                        return playerLetter;
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid one ");
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter valid one ");
                }
            }
        }

        public static char getComputerLetter(char playerLetter)
        {
            if (playerLetter == 'X')
            {
                return 'O';
            }
            else
            {
                return 'X';
            }
        }
        public static void UC3_showBoard(char[] positions)
        {
            Console.WriteLine("*** Board postions ***");
            Console.WriteLine(positions[1] + "|" + positions[2] + "|" + positions[3]);
            Console.WriteLine("------");
            Console.WriteLine(positions[4] + "|" + positions[5] + "|" + positions[6]);
            Console.WriteLine("------");
            Console.WriteLine(positions[7] + "|" + positions[8] + "|" + positions[9]);
        }

        public static void UC5_makeAMove(char[] positions, char playerLetter)
        {
            while (true)
            {
                Console.Write("Make a move... Choose one from [1-9] : ");
                try
                {
                    int move = Convert.ToInt32(Console.ReadLine());
                    if (positions[move] == ' ')
                    {
                        positions[move] = playerLetter;
                        break;
                    }
                    else if (move > 0 && move < 10)
                    {
                        Console.WriteLine("Place is occupied");
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter valid number");
                }
            }
        }

    }
}
