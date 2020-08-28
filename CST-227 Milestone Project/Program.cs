using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Joey Gallotta
//CST-227 Milestone Project

namespace CST_227_Milestone_Project
{
	class Program
	{
		//create instance of Board 
		static Board b = new Board(45);
        static BoardService boardService;
        static Game g = new Game();
        static GameService gameService;

		public static void Main(string[] args)
		{
            //print empty game board
            boardService = new BoardService(b);
            boardService.printBoard();
            boardService.countBombsNearCells();
            Console.ReadLine();
            gameService.GameLoop();
        }
    }
}