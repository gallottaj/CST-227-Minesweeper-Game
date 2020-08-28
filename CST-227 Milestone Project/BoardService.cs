using System;
using System.Data;
using System.Linq;

namespace CST_227_Milestone_Project
{
    public class BoardService
    {
        public Board b;
        public Cell c;
        public BoardService(Board gameBoard)
        {
            b = gameBoard;
        }

        public void populateBoardWithBombs()
        {
            //random percentage between 15-20 to activate live cells
            Random rand = new Random();
            double percent = rand.Next(15, 20);
            percent = percent / 100;

            //cell count 
            double numOfCells = b.xSize * b.xSize;

            //number of cells that will be live 
            double ranCount = Math.Round(numOfCells * percent, 0);

            //array of ints to hold the number of random live cells 
            int[] ranLive = new int[Convert.ToInt32(ranCount)];

            //loop to turn the cells live
            for (int actCells = 0; actCells < ranCount; actCells++)
            {
                //generate a random cell from grid
                double cellLive = rand.Next(0, Convert.ToInt32(numOfCells));

                //create an int to search the index of the ranLive array for the number of cellLive
                int live = Array.IndexOf(ranLive, cellLive);

                if (live > -1)
                {
                    return;
                }
                else
                {
                    ranLive[actCells] = Convert.ToInt32(cellLive);
                }

            }

            //Loop to make cells live.
            int liveCounter = 0;
            for (int i = 0; i < b.Grid.GetLength(0); i++)
            {
                for (int j = 0; j < b.Grid.GetLength(0); j++)
                {
                    if (ranLive.Contains(liveCounter))
                    {
                        b.Grid[i, j].isBomb = true;
                    }
                    liveCounter++;
                }
            }
        }


        public void countBombsNearCells()
        {
            //create a random percentage between 15-20 % to create live cells 
            Random rand = new Random();
            double percent = rand.Next(15, 20);
            percent = percent / 100;

            //find the complete cell count 
            double numOfCells = b.xSize * b.xSize;

            //find the number of cells that will be live 
            double ranCount = Math.Round(numOfCells * percent, 0);

            //create an array of ints to hold the number of random live cells 
            int[] ranLive = new int[Convert.ToInt32(ranCount)];

            //print test
            Console.WriteLine("number of live cells is " + ranCount);
            Console.WriteLine("Enter a row number");
            int currentRow = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a column number");

        }


        public void printBoard()
        {
            for (int i = 0; i < b.xSize; i++)
            {
                for (int j = 0; j < b.xSize; j++)
                {
                    Cell c = b.Grid[i, j];
                    if (c.isBomb == true)
                    {
                        Console.Write("*");
                    }
                    else if (c.isVisited == true)
                    {
                        Console.Write("~");

                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            populateBoardWithBombs();
        }

        //mark cells as visited = true
        //recursively call floodfill on surrounding cells
        private void floodFill (int row, int col)
        {
            if (visited(row, col))
            {
                // change the current cell to "~" when clicked
                b.Grid[row, col].isVisited = true;
                floodFill(row + 1, col);
                floodFill(row - 1, col);
                floodFill(row, col + 1);
                floodFill(row, col - 1);
            }
        }

        private bool visited(int row, int col)
        {
            if (row >= 0 && row < c.row && col >=0 && col < c.column)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
