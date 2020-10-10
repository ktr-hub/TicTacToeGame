using System;

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
        static void Main(string[] args)
        {
            char []positions = createBoard();
        }
    }
}
