using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG.Characters
{
    class Character
    {
        private int health;
        private string name;
        private string motto;
        private Move[] moveset;

        public Character(int _health, string _name, string _motto, Move[] _moveset)
        {
            Health = _health;
            Name = _name;
            Motto = _motto;
            Moveset = _moveset;
        }

        public int Health {
            get => health;
            set => health = value;
        }

        public string Name {
            get => name;
            set => name = value;
        }

        public string Motto {
            get => motto;
            set => motto = value;
        }

        public Move[] Moveset {
            get => moveset;
            set => moveset = value;
        }

        public void onCall()
        {
            Name = "Name has not been instantiated... ";
            Health = -1;
            moveset = null;
        }

        public void takeDamage(int _damage)
        {
            Health -= _damage;
        }

        public string toString()
        {
            List<string> moveNames = new List<string>();
            foreach (Move m in Moveset) {
                int i = 0;
                moveNames.Add(m.MoveName);
                i++;
            }

            return Name + ", has " + Health + " health, " + Motto + " is their motto. " + "Their moveset is: " + string.Join(", ", moveNames);
        }
    }
}
