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

        public void onCall()
        {
            Name = ("Name has not been instantiated... ");
            Health = -1;
        }

        public void takeDamage(int _damage)
        {
            Health -= _damage;
        }
    }
}
