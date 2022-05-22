using System;
using System.Collections.Generic;
using System.Text;

namespace Igrice
{
    class Gameplay
    {
        public static bool PlayTurn(Player attacker, Player defender)
        {
            Console.WriteLine("[" + attacker.getName() + "] is on turn");
            int spellCounter = 1;
            foreach (string spell in attacker.getSpells())
            {
                Console.Write("[" + spellCounter + "] " + spell + " -- ");
                spellCounter++;
            }
            string spellNumber = Console.ReadLine();

            double dmg = attacker.attack();
            defender.takeDmg(dmg);
            if (defender.getHp() <= 0)
            {
                Console.WriteLine("[" + attacker.getName() + "] won");
                attacker.addWin();
                PrintResult(attacker, defender);
                return true;
            }

            attacker.CastSpell(spellNumber, defender);
            return false;
  
            /*else if (spellNumber.Equals("1"))
            {
                attacker.heal();
            }
            else
            {
                Console.WriteLine("Spell unavailable");
            }
            attacker.gainMana();
            return false;*/
        }

        public static void PrintResult(Player player1, Player player2)
        {
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("[" + player1.getName() + "] " + player1.getWins() + " - "
                + player2.getWins() + " [" + player2.getName() + "]");
            Console.WriteLine("----------------------------------------------------------------");
        }
        
        public static void PrintState(Player player1, Player player2)
        {
            Console.WriteLine("[" + player1.getName() + "] " + player1.getHp() + " HP/" + player1.getMana() + " MANA");
            Console.WriteLine("[" + player2.getName() + "] " + player2.getHp() + " HP/" + player2.getMana() + " MANA");
            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}
