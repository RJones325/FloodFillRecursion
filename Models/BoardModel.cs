// Name: Ray Jones
// Course: CST-250
// Instructor: Gary Ratterree
// Assignment: Activity 3 – Flood Fill
// Date: 04/19/2026

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloodFillRecursion.Models
{
    internal class BoardModel
    {
        public int Size { get; set; }
        public CellModel[,] Cells { get; set; }

        public BoardModel(int size)
        {
            Size = size;
            Cells = new CellModel[size, size];

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Cells[row, col] = new CellModel(row, col);
                }
            }
        }
    }
}