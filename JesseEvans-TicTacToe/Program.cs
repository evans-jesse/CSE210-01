using System;

/*
Tic-Tac-Toe is played according to the following rules.

1. The game is played on a grid that is three squares by three squares.
2. Player one uses x's. Player two uses o's.
3. Players take turns putting their marks in empty squares.
4. The first player to get three of their marks in a row (vertically, horizontally, or diagonally) is the winner.
5. If all nine squares are full and neither player has three in a row, the game ends in a draw.
*/

namespace JesseEvans_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            int turn = 1;
            String turnLetter;
            String response;
            string[] array = new string[] {"1","2","3","4","5","6","7","8","9"};

            BuildBoard(array);
        }
        static void BuildBoard(string[] board)
        {
            Console.WriteLine(board[0] + "|" + board[1] + "|" + board[2]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(board[3] + "|" + board[4] + "|" + board[5]);
            // Console.WriteLine("4|5|6");
            Console.WriteLine("-+-+-");
            // Console.WriteLine("7|8|9");
            Console.WriteLine(board[6] + "|" + board[7] + "|" + board[8]);
        }
        static void gameplay(string[] temp)
        {
            
        }
    }
}