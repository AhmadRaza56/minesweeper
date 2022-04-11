using System;

namespace MineSweeper
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.WriteLine("Welcome to Minesweeper!");
			Console.WriteLine("Please choose the difficulty. Easy, Medium or Hard");
			Board board = new Board(Console.ReadLine(), 0, 0);
			//creating grid size
			
		}
	}
}


