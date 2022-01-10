// See https://aka.ms/new-console-template for more information

using System;
using System.Text.RegularExpressions;


/**
* @author Jesse Evans
* @assignment Tic Tac Toe
*/


namespace JSE.TicTacToe 
{
      internal class Program
      {
      static void Main(string[] args)
      {
            // Initialize Variables
            int turn = 1;
            String turnLetter;
            String? response;
            String regexAllowedChars = @"^[1-9]$";
            string[] array = new string[] {"1","2","3","4","5","6","7","8","9"};

            // Add blank spaces to make the Console look better
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Loop until the game is over
            do {
                  // Initialize response for each loop
                  response = "";

                  // Call function to write gameboard
                  writeGameboard(array);

                  // Set Player Turn
                  if(turn % 2.0 == 0){
                        turnLetter = "O";
                  }
                  else {
                        turnLetter = "X";
                  }

                  // Get input form user
                  Console.Write(turnLetter + "s turn to choose a square (1-9): ");
                  response = Console.ReadLine();
                  Console.WriteLine();

                  // Validate entry is valid
                  if(Regex.IsMatch(response, regexAllowedChars) == false){
                        Console.WriteLine("Invalid Entry.  Enter an integer between 1 and 9.");
                        Console.WriteLine();
                        continue;
                  }

                  // Validate the selected space is available
                  int item = (Convert.ToInt32(response)) - 1;
                  if(array[item] == "X" || array[item] == "O"){
                        Console.WriteLine("That spot has already been taken.");
                        Console.WriteLine();
                        continue;
                  }
                  else {
                        // Update array for this turn
                        array[item] = turnLetter;
                  }
                  
                  // Determine if this turn wins the game
                  if(winStatus(array)){
                        
                        // Call function to write gameboard
                        writeGameboard(array);
                        
                        // Write Winning statement.
                        Console.WriteLine("Good Game.  " + turnLetter + " won the game.  Thanks for playing!");
                        
                        // Set turn count to Exit the loop
                        turn = 100;
                        //break;
                  }

                  // Check if the game is ended without a winner.
                  if(turn == 9){
                        // Call function to write gameboard
                        writeGameboard(array);
                        
                        // Write "No Winner" statement.
                        Console.WriteLine("Game Over.  No Winner.");
                  }

                  // Increment the turn count.
                  turn++;

                  // If turn count = 10, the game ended witout a winner.
            } while (turn < 10);

            Console.WriteLine();

        }  // END Method - main

      private static void writeGameboard(String[] gameBoard){
            // Write the gameboard
            Console.WriteLine(gameBoard[0] + "|" + gameBoard[1] + "|" +  gameBoard[2]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(gameBoard[3] + "|" + gameBoard[4] + "|" +  gameBoard[5]);
            Console.WriteLine("-+-+-");
            Console.WriteLine(gameBoard[6] + "|" + gameBoard[7] + "|" +  gameBoard[8]);
            Console.WriteLine();
      }  // End Function - writeGameboard
      
      private static bool winStatus(String[] gameBoard){
            // Checked if a winning combination exists - Retun status.
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

      }  // End Function - winStatus
    }  //END class - Program
}  // END namespace - JSE.TicTacToe
