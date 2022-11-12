using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GameGitDemo
{
    class Game
    {
        public void Run()   // a method we will call when we want the game to run
        {
            WriteLine("=== Welcome to the game ===");

            WriteLine("\nPress any key to exit...");
            ReadKey(true);
        }
    }
}
