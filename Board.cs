using System;
using System.Security.Cryptography.X509Certificates;

public class Class1
{
	public Board()
	{
		public Cell[,] square;
		
		public Grid(int grid)
    {
		sqaure = new Cell[grid, grid];

		for(int i = 0; i < square.GetLength(0); i++)
        {
			for (int k = 0; k <square.GetLength(0); k++)
            {
				square[i, k] = new Cell();
				square[i, k].setRow(i);
				square[i, k].setColumn(k);
            }
        }
		}
	}
}
