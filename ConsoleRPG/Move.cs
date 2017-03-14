using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    class Move
    {
        private string moveName;
        private int manaCost;
        private int baseDamage;
        private double damageScale;
        private int cooldown;

        public string MoveName {
            get => moveName;
            set => moveName = value;
        }

        public int ManaCost {
            get => manaCost;
            set => manaCost = value;
        }

        public int BaseDamage {
            get => baseDamage;
            set => baseDamage = value;
        }

        public double DamageScale {
            get => damageScale;
            set => damageScale = value;
        }

        public int Cooldown {
            get => cooldown;
            set => cooldown = value;
        }

        public Move(string _moveName, int _manaCost, int _baseDamage, double _damageScale, int _cooldown)
        {
            MoveName = _moveName;
            ManaCost = _manaCost;
            BaseDamage = _baseDamage;
            DamageScale = _damageScale;
            Cooldown = _cooldown;
        }

        public int damageOutput(double addedDamage)
        {
            int damage;
            double scaledDamage = this.damageScale * addedDamage;
            damage = baseDamage + (int)Math.Round(scaledDamage);
            return damage;
        }

        public string toString()
        {
            return MoveName + ", costs " + ManaCost + " Mana, " + BaseDamage + " damage, has " + DamageScale + " scaling.";
        }
    }
}
