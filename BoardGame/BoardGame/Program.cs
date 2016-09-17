using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame
{
    class Program
    {
        public static void Main(string[] args)
        {
            Game g = new Game();
            g.Run();
            Console.ReadLine();
        }
    }
}
