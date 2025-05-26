namespace ProjectEulerProblems.Problems
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class that builds grids by begining in the center and moving to the right in a clockwise direction.
    /// </summary>
    public static class SpiralGrid
    {
        /// <summary>
        /// Gets the sum of the diagonal entries of a spiral grid.
        /// </summary>
        /// <param name="size">The size of the spiral grid we want.</param>
        /// <returns>The sum of the diagonal entries of the sprial grid.</returns>
        public static int GetDiagonalSumOfSpiralGrid(int size)
        {
            var grid = BuildSpiralGrid(size);
            var diagonalList = new List<int>();
            var sum = 0;
            for (int i = 0; i < grid.Length / size; i++)
            {
                for (int j = 0; j < grid.Length / size; j++)
                {
                    if (i == j || i + j == size - 1)
                    {
                        diagonalList.Add(grid[i, j]);
                        sum += grid[i, j];
                    }
                }
            }

            return sum;
        }

        /// <summary>
        /// Builds an size x size grid starting a the center and moving to the right in a clockwise direction. 
        /// </summary>
        /// <param name="size">Number of rows and columns in the gird.</param>
        /// <returns>And size x size spiral grid.</returns>
        private static int[,] BuildSpiralGrid(int size)
        {
            var spiralGrid = new int[size, size];

            int row = size / 2;
            int col = size / 2;

            if (size % 2 == 0)
            {
                row = (size / 2) - 1;
                col = (size / 2) - 1;
            }

            spiralGrid[row, col] = 1;

            int currentValue = 2;
            int stepsToMove = 1;

            var directions = new (int RowChange, int ColChange)[]
            {
                (0, 1),   // right
                (1, 0),   // down
                (0, -1),  // left
                (-1, 0),  // up
            };

            while (currentValue <= size * size)
            {
                for (int dir = 0; dir < 4; dir++)
                {
                    var (rowChange, colChange) = directions[dir];

                    for (int step = 0; step < stepsToMove; step++)
                    {
                        row += rowChange;
                        col += colChange;

                        if (row >= 0 && row < size && col >= 0 && col < size)
                        {
                            spiralGrid[size - 1 - row, col] = currentValue;
                            currentValue++;
                        }

                        if (currentValue > size * size)
                        {
                            break;
                        }
                    }

                    // increase step size after a verticle move.
                    if (dir % 2 == 1)
                    {
                        stepsToMove++;
                    }

                    // Break the outter loop if we've gone over.
                    if (currentValue > size * size)
                    {
                        break;
                    }
                }
            }

            return spiralGrid;
        }
    }
}
