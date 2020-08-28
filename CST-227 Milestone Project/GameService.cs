using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CST_227_Milestone_Project
{
    class GameService
    {
        public Game g;
        public Board b;

        public void GameLoop()
        {
            g.gameOver = false;
            
            while (g.gameOver == false)
            {
                Console.WriteLine("Enter row number");
                int currentRow = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter column number");
                int currentColumn = int.Parse(Console.ReadLine());

                Console.WriteLine(b.Grid[currentRow, currentColumn]);
                break;
            }
            Console.WriteLine("Game over");
        }
    }
}
