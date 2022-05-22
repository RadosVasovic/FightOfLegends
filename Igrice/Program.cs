using System;

namespace Igrice
{
    class Program
    {
        static void Main(string[] args)
        {
            PickChampion pickChampion = new PickChampion();
            foreach(string player in pickChampion.GetChampions())
            {
                Console.Write(player);
            }

            Console.Write("player 1 name: ");
            string player1 = Validator.GetPlayerName();

            Console.Write("Champion number: ");
            string championNo = Validator.GetChampionNo(pickChampion.GetChampions().Count).ToString();

            Console.Write("Champion level: ");
            int level;
            string levelStr = Console.ReadLine();
            Int32.TryParse(levelStr, out level);

            Player yasuo = pickChampion.SelectChampion(championNo, player1, level);

            foreach (string player in pickChampion.GetChampions())
            {
                Console.Write(player);
            }

            Console.Write("player 2 name: ");
            string player2 = Validator.GetPlayerName();

            Console.Write("Champion number: ");
            championNo = Validator.GetChampionNo(pickChampion.GetChampions().Count).ToString();

            Console.Write("Champion level: ");
            levelStr = Console.ReadLine();
            Int32.TryParse(levelStr, out level);

            Player bard = pickChampion.SelectChampion(championNo, player2, level);

            Result.ReadResult(yasuo, bard);

            while(true) 
            {
                if (Gameplay.PlayTurn(yasuo, bard))
                {
                    Result.writeResult(yasuo, bard);
                    break;
                }
                if (Gameplay.PlayTurn(bard, yasuo))
                {
                    Result.writeResult(yasuo, bard);
                    break;
                }

                Gameplay.PrintState(yasuo, bard);
            }

        }
    }
}
