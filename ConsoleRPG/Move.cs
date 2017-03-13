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

        public Move(string _moveName, int _manaCost, int _baseDamage, double _damageScale)
        {
            this.moveName = _moveName;
            this.manaCost = _manaCost;
            this.baseDamage = _baseDamage;
            this.damageScale = _damageScale;
        }

        public int useMove(double addedDamage)
        {
            int damage;
            double scaledDamage = this.damageScale * addedDamage;
            damage = baseDamage + (int)Math.Round(scaledDamage);
            return damage;
        }

        public int getBaseDamage()
        {
            return baseDamage;
        }

        public void setBaseDamage(int _baseDamage)
        {
            this.baseDamage = _baseDamage;
        }

        public double getDamageScale()
        {
            return damageScale;
        }

        public void setDamageScale(int _damageScale)
        {
            damageScale = _damageScale;
        }
    }
}
