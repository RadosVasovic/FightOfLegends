using System;
using System.Collections.Generic;
using System.Text;

namespace Igrice
{
    class PickChampion
    {
        private List<string> champions = new List<string>();

        public PickChampion() 
        {
            champions.Add("[1] Yasuo\n");
            champions.Add("[2] Bard\n");
        }

        public Player SelectChampion(string championNo, string name, int level)
        {
            switch (championNo)
            {
                case "1":
                    return new Yasuo(name, level);
                    break;
                case "2":
                    return new Bard(name, level);
                    break;
                default:
                    return new Yasuo(name, level);
                    break;
            }
        }

        public List<string> GetChampions()
        {
            return this.champions;
        }
    }
}
