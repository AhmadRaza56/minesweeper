﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    internal class Mines
    {
		//mines
		//compare mine with row and column
		int mines = 0;

		public Mines()
        {
            Board board = new Board(Console.ReadLine(),0,0);
            if (board.getdifficulty().Contains("easy"))
            {
                Random rmd = new Random();
                while (mines == 5)
                {
                    int minelocation1 = rmd.Next(0,11);
                    int minelocation2 = rmd.Next(0, 11);
                    int minelocation3 = rmd.Next(0, 11);
                    int minelocation4 = rmd.Next(0, 11);
                    int minelocation5 = rmd.Next(0, 11);
                }
            }
            else if (board.getdifficulty().Contains("medium"))
            {
                Random rmd = new Random();
                while (mines == 10)
                {

                }
            }
            else if (board.getdifficulty().Contains("hard"))
            {
                Random rmd = new Random();
                while (mines == 20)
                {

                }
            }

        }
		
    }
}
