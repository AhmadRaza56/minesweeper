using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    internal class Board
    {
		int horizontal;
		int vertical;
		string size;
		

		public Board(string difficulty, int width, int height)
        {
			this.vertical = height;
			this.horizontal = width;
			this.size = difficulty;

            if (difficulty.ToLower() == "easy")
            {
				height = 10;
				width = 10;
				int[,] grid = new int[height, width];
				for (int y = 0; y < width; ++y)
				{
					//run a nested loop
					for (int x = 0; x < height; ++x)//loop through an inner array
					{
						grid[x, y] = 0;
						Console.Write(grid[x, y] + " ");
					}
					Console.WriteLine();
				}
			}
			else if (difficulty.ToLower() == "medium")
			{
				height = 16;
				width = 16;
				int[,] grid = new int[height, width];
				for (int y = 0; y < width; ++y)
				{
					for (int x = 0; x < height; ++x)
					{
						grid[x, y] = 0;
						Console.Write(grid[x, y] + " ");
					}
					Console.WriteLine();
				}
			}
			else if (difficulty.ToLower() == "hard")
			{
				height = 20;
				width = 20;
				int[,] grid = new int[height, width];
				for (int y = 0; y < width; ++y)
				{
					for (int x = 0; x < height; ++x)
					{
						grid[x, y] = 0;
						Console.Write(grid[x, y] + " ");
					}
					Console.WriteLine();
				}
			}
		}
	}
}
