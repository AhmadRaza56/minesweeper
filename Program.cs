using System;

namespace minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
			const int Horizontal = 5;
			const int Vertical = 3;


			int[][] grid = new int[Vertical][];//this will have 10 arrays inside
			for (int x = 0; x < grid.Length; ++x)
			{
				//initialise each sub array
				grid[x] = new int[Horizontal];//the inner array will have 6 elements
			}

			Random rand = new Random();

			//fill the grid with random values
			for (int x = 0; x < grid.Length; ++x)
			{
				//run a nested loop
				for (int y = 0; y < grid[x].Length; ++y)//loop through an inner array
				{
					grid[x][y] = rand.Next(10);//random value between 0 and 10 (inclusive)
					Console.Write(grid[x][y] + " ");
				}
				Console.WriteLine();
			}

		}

    }
}


