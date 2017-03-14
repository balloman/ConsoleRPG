using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRPG.Characters;

namespace ConsoleRPG
{
    /*This is the player class
     * We do this because our main class should only run the program not deifine the palyer
     * This allows us to have a base template for any player, which can be edited.
     * This is OOP(Object Oriented Programming) */

    class Player : Character
    {
        private int mana;

        public int Mana {
            get => mana;
            set => mana = value;
        }

        public Player(int _health, int _mana, string _name, string _motto, Move[] _moveset) : base(_health, _name, _motto, _moveset)
        {
            Health = _health;
            Mana = _mana;
            Name = _name;
            Motto = _motto;
            Moveset = _moveset;
        }

        public Player() : base(1000, "Player1", "Hey Guys!", new Move[] { new Move("Portal Blast", 0, 56, 0.3, 1),
                                                                new Move("Cosmic Rift", 100, 100, 0.8, 3),
                                                                new Move("Tether", 30, 60, 0.6, 2),
                                                                new Move("Black Hole", 175, 350, 1.2, 7) })
        {
            Mana = 750;
        }
    }
}
