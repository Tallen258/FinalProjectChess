using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardConsoleApp
{
    class Program
    {
        static Board myBoard = new Board(8);
        static void Main(string[] args)
        {

            // Show the empty chess board
            printBoard(myBoard);
            // Ask the user for an x and y coordinates where we will place a piece

            // Calculate all legal moves for that place

            // Print the chess board. Use an X for occupied square. Use a + for legal move. Use "." for empty cell. 

            // Wait for another enter key press before ending the program.
            Console.ReadLine();
        }

        private static void printBoard(Board myBoard)
        {
            // print the chess board to the console. Use X for the piece location. + for legal move.
            for (int i = 0; i < myBoard.length; i++)
            {
                for (int j = 0; j < myBoard.length; j++)
                {
                    Cell c = myBoard.theGrid[i, j];
                
                if (c.CurrentlyOccupoed == true)
                {
                    Console.Write("X");
                }
                else if (c.LegalNextMove == true)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            }

            Console.WriteLine("=============================");
            
        }
    }
}
