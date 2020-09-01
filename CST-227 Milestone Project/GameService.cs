using System;

namespace CST_227_Milestone_Project
{
    internal class GameService
    {
        public Board Board;
        public Game Game;

        public GameService(Game game, Board board)
        {
            Game = game;
            Board = board;
        }

        public void GameLoop()
        {
            Game.gameOver = false;

            while (Game.gameOver == false)
            {
                Console.WriteLine("Enter row number");
                var currentRow = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter column number");
                var currentColumn = int.Parse(Console.ReadLine());

                Console.WriteLine(Board.Grid[currentRow, currentColumn]);
                break;
            }

            Console.WriteLine("Game over");
        }
    }
}