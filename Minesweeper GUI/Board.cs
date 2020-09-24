using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Joey Gallotta
//CST-227 Milestone Project

namespace CST_227_Milestone_Project
{
	public class Board
	{
		public int xSize { get; set; }

		public Cell[,] Grid { get; set; }

		//constructor
		public Board(int s)
		{
			//set initial size of board as s
			xSize = s;

			//initialize new 2d grid 

			Grid = new Cell[xSize, xSize];

			// initiate values in grid
			for (int i = 0; i < xSize; i++)
			{
				for (int j = 0; j < xSize; j++)
				{
					Grid[i, j] = new Cell(i, j);
				}
			}
		}
		//A method to randomly initialize the grid with live bombs.
		//Difficulty property to determine what percentage of the cells in the grid will be set to "live" status.

		public void IsBombMethod()
		//A way to determine if the cell is a bomb: random percentage? A method to randomly initialize the grid with live bombs.
		{
			double numberOfCells = xSize * xSize;

			//generate random number to be used as percentage
			Random rand = new Random();
			double percent = rand.Next(15, 20);

			//determine actual cell count
			percent = percent / 100;
			double count = Math.Round(numberOfCells * percent, 0);
		}


		//if statement to check if each of the 8 positions around the cell have an isBomb == true
		public void setupLiveNeighbors(Cell currentCell, string neighbor)
		{

		}

	//pblic int getNumberOfNearByBombs(Cell cell)

	}
}
