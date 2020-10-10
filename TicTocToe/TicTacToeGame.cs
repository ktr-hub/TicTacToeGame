using System;
using System.Dynamic;
using System.Threading.Channels;

namespace TicTocToe
{
    class TicTacToeGame
    {
        public static char[] createBoard()
        {
            char []positions = new char[10];
            for(int i = 1; i < 10; i++)
            {
                positions[i] = ' ';
            }
            return positions;
        }

        public static char getPlayerLetter()
        {
            while (true)
            {
                Console.Write("Please enter your letter(X or O) : ");
                try
                {
                    char playerLetter;
                    char inputLetter = Convert.ToChar(Console.Read());
                    if (inputLetter == 'X')
                    {
                        playerLetter = 'X';
                        return playerLetter;
                    }
                    else if (inputLetter == 'O')
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
                    Console.WriteLine("Please enter valid one");
                }
            }
        }

        static void Main(string[] args)
        {
            char []positions = createBoard();
            char playerLetter = getPlayerLetter();
            char computerLetter;
            if (playerLetter == 'X')
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
