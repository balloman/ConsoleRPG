using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Characters;

namespace ConsoleRPG
{
    class Program
    {
        private static void Main(string[] args)
        {
            Move portalBlast = new Move("Portal Blast", 0, 56, 0.3, 1);
            //Console.WriteLine(portalBlast.toString());
            Console.WriteLine(portalBlast.MoveName + " with 212 power does " + portalBlast.damageOutput(212) + " damage.");

            Player player1 = new Player();
            Console.WriteLine(player1.toString());
            Console.WriteLine("Black Hole does " + player1.Moveset[3].damageOutput(212) + " damage with 212 power");

            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
