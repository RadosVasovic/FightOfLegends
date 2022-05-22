using System;
using System.Collections.Generic;
using System.Text;

namespace Igrice 
{
    class Yasuo : Player
    {
        private string name;

        public Yasuo(string name, int level) : base(level)
        {
            this.name = name;
            this.hp += level * 50;
            this.spells.Add("strike");
        }
        public override double attack()
        {
            Random r = new Random();
            double dmg = 200;
            if(this.mana - 50 <= 0)
            {
                Console.WriteLine("Not enought mana");
                return 0;
            }
            else
            {
                this.mana -= 50;
            }

            if (r.NextDouble() > 0.5)
            {
                dmg += r.NextDouble() * 100;
            }
            else if(r.NextDouble() > 0.95)
            {
                dmg *= r.NextDouble() * 100;
            }
            else
            {
                dmg -= r.NextDouble() * 100;
            }
            return dmg;
        }

        public override void heal()
        {
            Random r = new Random();
            double heal = r.NextDouble() * 100;
            if (this.mana - 40 <= 0)
            {
                Console.WriteLine("Not enought mana");
            }
            else
            {
                this.mana -= 40;
            }

            if (r.NextDouble() > 0.8)
            {
                heal *= 2;
            }
            if(hp + heal > 1000 + level * 50)
            {
                this.hp = 1000;
            }
            else
            {
                this.hp += heal;
            }
        }

        public override void takeDmg(double dmg)
        {
            this.hp -= dmg;
        }

        public override double getHp()
        {
            return this.hp;
        }

        public override string getName()
        {
            return name;
        }

        public override double getMana()
        {
            return this.mana;
        }
        public override void gainMana()
        {
            this.mana += 20;
        }

        public override int getWins()
        {
            return this.wins;
        }

        public override void addWin()
        {
            this.wins++;
        }

        public override List<string> getSpells()
        {
            return this.spells;
        }

        public override void CastSpell(string spellNumber, Player opponent)
        {
            switch (spellNumber)
            {
                case "1":
                    this.heal();
                    break;
                case "2":
                    this.Strike(opponent);
                    break;
            }
        }

        private void Strike(Player opponent)
        {
            opponent.takeDmg(500); 
        }
    }
}
