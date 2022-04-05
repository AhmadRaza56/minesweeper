using System;

namespace minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
			//creating grid size
			Console.WriteLine("Please choose the difficulty. Easy, Medium or Hard");
			string size = Console.ReadLine(); 
			if (size.ToLower() == "easy")
            {
				int horizontal = 10;
				int vertical = 10;
				int[][] grid = new int[vertical][];

				for (int x = 0; x < grid.Length; ++x)
				{
					grid[x] = new int[horizontal];
				}

				for (int x = 0; x < grid.Length; ++x)
				{
					//run a nested loop
					for (int y = 0; y < grid[x].Length; ++y)//loop through an inner array
					{
						grid[x][y] = 0;
						Console.Write(grid[x][y] + " ");
					}
					Console.WriteLine();
				}
			}
			else if (size.ToLower() == "medium")
            {
				int horizontal = 16;
				int vertical = 16;
				int[][] grid = new int[vertical][];

				for (int x = 0; x < grid.Length; ++x)
				{
					grid[x] = new int[horizontal];
				}

				for (int x = 0; x < grid.Length; ++x)
				{
					//run a nested loop
					for (int y = 0; y < grid[x].Length; ++y)//loop through an inner array
					{
						grid[x][y] = 0;
						Console.Write(grid[x][y] + " ");
					}
					Console.WriteLine();
				}
			}
			else if (size.ToLower() == "hard")
            {
				int horizontal = 20;
				int vertical = 20;
				int[][] grid = new int[vertical][];

				for (int x = 0; x < grid.Length; ++x)
				{
					grid[x] = new int[horizontal];
				}

				for (int x = 0; x < grid.Length; ++x)
				{
					//run a nested loop
					for (int y = 0; y < grid[x].Length; ++y)//loop through an inner array
					{
						grid[x][y] = 0;
						Console.Write(grid[x][y] + " ");
					}
					Console.WriteLine();
				}
			}			 
			 //end grid cretions size

			 //start mines

		}

	}
}


