using System;
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
            Board board = new Board(Console.ReadLine(), 0, 0);
            if (board.getdifficulty() == "easy")
            {

            }
            else if (board.getdifficulty() == "medium")
            {

            }
            else if (board.getdifficulty() == "hard")
            {

            }
        }
		
    }
}
