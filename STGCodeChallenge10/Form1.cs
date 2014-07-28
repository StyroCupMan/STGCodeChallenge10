using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace STGCodeChallenge10
{
    public partial class Form1 : Form
    {
        int[,] Puzzle1 = new int[,] 
            {{5, 3, 4, 6, 7, 8, 9, 1, 2}, 
            {6, 7, 2, 1, 9, 5, 3, 4, 8},
            {1, 9, 8, 3, 4, 2, 5, 6, 7},
            {8, 5, 9, 7, 6, 1, 4, 2, 3},
            {4, 2, 6, 8, 5, 3, 7, 9, 1},
            {7, 1, 3, 9, 2, 4, 8, 5, 6},
            {9, 6, 1, 5, 3, 7, 2, 8, 4},
            {2, 8, 7, 4, 1, 9, 6, 3, 5},
            {3, 4, 5, 2, 8, 6, 1, 7, 9}};

        int[,] Puzzle2 = new int[,] 
            {{5, 3, 4, 6, 7, 8, 9, 1, 2}, 
            {6, 7, 2, 1, 9, 0, 3, 4, 8},
            {1, 0, 0, 3, 4, 2, 5, 6, 0},
            {8, 5, 9, 7, 6, 1, 0, 2, 0},
            {4, 2, 6, 8, 5, 3, 7, 9, 1},
            {7, 1, 3, 9, 2, 4, 8, 5, 6},
            {9, 0, 1, 5, 3, 7, 2, 1, 4},
            {2, 8, 7, 4, 1, 9, 6, 3, 5},
            {3, 0, 0, 4, 8, 1, 1, 7, 9}};

        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate1_Click(object sender, EventArgs e)
        {
            CheckPuzzle(Puzzle1);
        }

        private void btnValidate2_Click(object sender, EventArgs e)
        {
            CheckPuzzle(Puzzle2);
        }

        private void CheckPuzzle(int[,] SudokuData)
        {
            MessageBox.Show(string.Format("The puzzle provided is {0}a valid Sudoku solution", (validSolution(SudokuData) ? "" : "not ")));
        }

        // Is our 9x9 multi-array of ints a valid Sudoku solution?
        private bool validSolution(int[,] SudokuData)
        {
            bool IsValid = true;

            // First make sure we have a valid 9x9 Sudoku Grid
            if (SudokuData.GetUpperBound(0) != 8 || SudokuData.GetUpperBound(1) != 8)
            {
                return false;
            }

            // We need to validate 9 rows, 9 columns, and 9 3x3 sub-grids
            // Do one of each for each iteration
            for (int i = 0; i < 9; i++)
            {
                IsValid &= Have1to9(GetLinearArrayX(SudokuData, i).ToArray<int>());
                IsValid &= Have1to9(GetLinearArrayY(SudokuData, i).ToArray<int>());
                IsValid &= Have1to9(GetSubGridArray(SudokuData, 3 * (i / 3), 3 * (i % 3)).ToArray<int>());
            }

            return IsValid;
        }

        // Iterator to grab one 3x3 sub-grid of the int[,] as an int[]
        private static IEnumerable<int> GetSubGridArray(int[,] array, int x, int y)
        {
            for (int i = 0; i < 9; i++)
                yield return array[x + (i / 3), y + (i % 3)];
        }

        // Iterator to grab one row of the int[,] as an int[]
        private static IEnumerable<int> GetLinearArrayX(int[,] array, int index)
        {
            for (int i = 0; i < array.GetLength(0); i++)
                yield return array[index, i];
        }

        // Iterator to grab one column of the int[,] as an int[]
        private static IEnumerable<int> GetLinearArrayY(int[,] array, int index)
        {
            for (int i = 0; i < array.GetLength(1); i++)
                yield return array[i, index];
        }

        // Function to determine if the array of ints contains all values 1..9
        private bool Have1to9(int[] Digits)
        {
            bool IsValid = true;

            IsValid = Digits.Contains(1) && Digits.Contains(2) && Digits.Contains(3) && 
                Digits.Contains(4) && Digits.Contains(5) && Digits.Contains(6) && 
                Digits.Contains(7) && Digits.Contains(8) && Digits.Contains(9);

            return IsValid;
        }
    }
}
