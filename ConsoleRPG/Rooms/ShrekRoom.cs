using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Rooms
{
    class ShrekRoom : Room
    {
        public ShrekRoom()
        {
        }

        public override void onEnter(Room upRoom)
        {
            Console.WriteLine("You have entered the lair of the one known as...");
            Thread.Sleep(750);
            Console.WriteLine("Shrek!");
            base.onEnter(upRoom);
        }
    }
}
