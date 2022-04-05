using System;

namespace minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
			//creating grid size
			 Console.WriteLine("Please enter number of rows");
			 int Horizontal = Int32.Parse(Console.ReadLine()); 
			 Console.WriteLine("Please enter number of columns");
			 int Vertical = Int32.Parse(Console.ReadLine());
			 int[][] grid = new int[Vertical][];

			 for (int x = 0; x < grid.Length; ++x)
			 {				
				grid[x] = new int[Horizontal];
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
			//end grid cretions size
		}

	}
}


