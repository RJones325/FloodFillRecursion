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
    internal class CellModel
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool IsVisited { get; set; }

        public CellModel(int row, int column)
        {
            Row = row;
            Column = column;
            IsVisited = false;
        }
        // Update and commit
    }
}