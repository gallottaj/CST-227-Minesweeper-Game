using System;

//Joey Gallotta
//CST-227 Milestone Project

namespace CST_227_Milestone_Project
{
    internal class Program
    {
        //create instance of Board 
        private static readonly Board Board = new Board(45);
        private static BoardService _boardService;
        private static readonly Game Game = new Game();
        private static GameService _gameService;

        public static void Main(string[] args)
        {
            //print empty game board
            _boardService = new BoardService(Board);
            _boardService.printBoard();
            _boardService.countBombsNearCells();
            Console.ReadLine();
            _gameService = new GameService(Game,Board);
            _gameService.GameLoop();
        }
    }
}