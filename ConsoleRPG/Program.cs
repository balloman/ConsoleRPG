using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    class Program
    {
        private static void Main(string[] args)
        {
            Move portalBlast = new Move("Portal Blast", 0, 56, 0.3);
            Console.WriteLine(portalBlast.toString());
        }
    }
}
