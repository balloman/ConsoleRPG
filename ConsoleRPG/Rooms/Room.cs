using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Characters;

namespace ConsoleRPG.Rooms
{
    abstract class Room
    {
        private string roomName;
        private Player _roomPlayer;

        public Player RoomPlayer {
            get => _roomPlayer;
            set => _roomPlayer = value;
        }

        public virtual void onEnter(Room upRoom)
        {
            if (this == null) {
                Console.Error.WriteLine("This room has not been initialized yet...");
            }
            if (upRoom != null) {
                upRoom.onEnter();
            }
            else {
                Console.WriteLine("Finished!");
            }
        }

        public void onEnter()
        {
        }
    }
}
