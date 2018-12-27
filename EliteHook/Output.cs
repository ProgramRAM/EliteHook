using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EliteHook
{
    public static class Output
    {
        public static void Start()
        {
            int orgWidth = Console.WindowWidth;
            int orgHeight = Console.WindowHeight;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WindowWidth = 140;
            Console.WindowHeight = 56;

            Console.Clear();
            foreach (var s in File.ReadAllLines("logo.txt"))
            {
                Console.WriteLine(s);
            }

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine(" EliteHook by CMDR Somfic.");
            Console.WriteLine(" github.com/EliteAPI");
            Thread.Sleep(3000);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowWidth = orgWidth;
            Console.WindowHeight = orgHeight;

            Console.Clear();
        }
    }
}
