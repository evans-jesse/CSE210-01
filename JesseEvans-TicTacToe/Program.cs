using System;

/*
Tic-Tac-Toe is played according to the following rules.

1. The game is played on a grid that is three squares by three squares.
2. Player one uses x's. Player two uses o's.
3. Players take turns putting their marks in empty squares.
4. The first player to get three of their marks in a row (vertically, horizontally, or diagonally) is the winner.
5. If all nine squares are full and neither player has three in a row, the game ends in a draw.
*/


/*
* @author Jesse Evans
* @assignment Tic Tac Toe
*/

namespace JesseEvans_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            int turn = 1;
            string turnLetter;
            string response;
            string[] array = new string[] {"1","2","3","4","5","6","7","8","9"};

            do{
                response = "";
                BuildBoard(array);

                if(turn % 2.0 == 0){
                    turnLetter = "O";
                }
                  else {
                    turnLetter = "X";
                }

                Console.Write(turnLetter + "s turn to choose a square (1-9): ");
                response = Console.ReadLine();
                Console.WriteLine();

                int item = (Convert.ToInt32(response)) - 1;
                if(array[item] == "X" || array[item] == "O"){
                    Console.WriteLine("That spot has already been taken.");
                    Console.WriteLine();
                    continue;  // Makes sure the turn doesn't increase.
                }
                  else {
                    array[item] = turnLetter;
                }

                if(winStatus(array)){
                    BuildBoard(array);
                    Console.WriteLine("Good Game.  " + turnLetter + " won the game.  Thanks for playing!");
                    turn = 100;
                }

                if(turn == 9){
                    BuildBoard(array);
                    Console.WriteLine("Game Over.  No Winner.");
                }
                  turn++;

            } while(turn < 10);
            
        }
        static void BuildBoard(string[] board)
        {
            Console.WriteLine(board[0] + "|" + board[1] + "|" + board[2]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(board[3] + "|" + board[4] + "|" + board[5]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(board[6] + "|" + board[7] + "|" + board[8]);
        }
        static bool winStatus(string[] gameBoard){
            if(   (gameBoard[0] == gameBoard[1] && gameBoard[1] == gameBoard[2])  ||
                  (gameBoard[3] == gameBoard[4] && gameBoard[4] == gameBoard[5])  ||
                  (gameBoard[6] == gameBoard[7] && gameBoard[7] == gameBoard[8])  ||

                  (gameBoard[0] == gameBoard[3] && gameBoard[3] == gameBoard[6])  ||
                  (gameBoard[1] == gameBoard[4] && gameBoard[4] == gameBoard[7])  ||
                  (gameBoard[2] == gameBoard[5] && gameBoard[5] == gameBoard[8])  ||

                  (gameBoard[0] == gameBoard[4] && gameBoard[4] == gameBoard[8])  ||
                  (gameBoard[2] == gameBoard[4] && gameBoard[4] == gameBoard[6])  ) {
                 
                 return true;
            }
            else {
                return false; 
            } 
        }
    }
}