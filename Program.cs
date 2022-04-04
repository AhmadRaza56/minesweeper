using System;

namespace minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number of rows");
           
            Console.WriteLine("Please enter number of columns");
            Board board = new Board(0,0);
            Console.WriteLine("Please enter the number of rows");
            board.setx(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the number of columns");
            board.sety(int.Parse(Console.ReadLine()));
            int numberOfbombs;
            string bomb = "x";

        }

    }
}


