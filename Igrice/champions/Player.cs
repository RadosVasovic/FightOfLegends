using System;
using System.Collections.Generic;
using System.Text;

namespace Igrice
{
    abstract class Player
    {
        protected double hp = 1000;
        protected double mana = 200;
        protected int level;
        protected int wins = 0;
        protected List<String> spells = new List<String>();

        public Player(int level) 
        {
            this.level = level;
            spells.Add("heal");
        }

        public abstract double attack();

        public abstract void heal();

        public abstract void takeDmg(double dmg);

        public abstract double getHp();

        public abstract string getName();

        public abstract double getMana();

        public abstract void gainMana();

        public abstract int getWins();

        public abstract void addWin();

        public abstract List<String> getSpells();

        public abstract void CastSpell(string spellNumber, Player opponent);

    }
}
