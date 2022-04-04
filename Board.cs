using System;

internal class Board
{
	int rows;
	int columns;	
	public Board(int x, int y)
	{
		this.rows = x;
		this.columns = y;
		int[,] board = new int[x, y];
	}

	public int getx()
    {
		return this.rows;
    }
	public void setx(int x)
    {
		this.rows = x;
    }
	public int gety()
	{
		return this.columns;
	}
	public void sety(int y)
	{
		this.columns = y;
	}
}
