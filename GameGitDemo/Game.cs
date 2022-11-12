using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameGitDemo
{
    class Game
    {
        public void Run()   // a method we will call when we want the game to run
        {
            Console.WriteLine("=== Welcome to the game ===");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
