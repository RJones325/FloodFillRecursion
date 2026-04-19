// Name: Ray Jones
// Course: CST-250
// Instructor: Gary Ratterree
// Assignment: Activity 3 – Flood Fill
// Date: 04/19/2026

using System;
using FloodFillRecursion.Models;

namespace FloodFillRecursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BoardModel board = new BoardModel(5);

            PrintBoard(board);

            int row = ReadIntFromConsole("Enter row: ");
            int col = ReadIntFromConsole("Enter column: ");

            FloodFill(board, row, col);

            Console.WriteLine("\nAfter Flood Fill:\n");
            PrintBoard(board);

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }

        static void PrintBoard(BoardModel board)
        {
            for (int row = 0; row < board.Size; row++)
            {
                for (int col = 0; col < board.Size; col++)
                {
                    Console.Write(board.Cells[row, col].IsVisited ? "X " : "O ");
                }
                Console.WriteLine();
            }
        }

        static void FloodFill(BoardModel board, int row, int col)
        {
            if (row < 0 || col < 0 || row >= board.Size || col >= board.Size)
            {
                return;
            }

            if (board.Cells[row, col].IsVisited)
            {
                return;
            }

            board.Cells[row, col].IsVisited = true;

            FloodFill(board, row - 1, col);
            FloodFill(board, row + 1, col);
            FloodFill(board, row, col - 1);
            FloodFill(board, row, col + 1);
        }

        static int ReadIntFromConsole(string prompt)
        {
            int value;
            bool isValid;

            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine() ?? "";

                isValid = int.TryParse(input, out value);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input.");
                }

            } while (!isValid);

            return value;
        }
    }
}