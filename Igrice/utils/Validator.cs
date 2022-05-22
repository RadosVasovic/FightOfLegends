using System;
using System.Collections.Generic;
using System.Text;

namespace Igrice
{
    class Validator
    {
        public static string GetPlayerName()
        {
            string name = Console.ReadLine();
            while(name.Split(' ').Length > 1)
            {
                Console.WriteLine("Invalid name, must be one word");
                name = Console.ReadLine();
            }
            return name;
        }

        public static int GetChampionNo(int numberOfChampions)
        {
            int number;
            while (true)
            {
                string numberStr = Console.ReadLine();
                Int32.TryParse(numberStr, out number);
                if (number < 1 || number > numberOfChampions)
                {
                    Console.WriteLine("Invalid champion number");
                    Console.Write("Champion number: ");
                }
                else
                {
                    return number;
                }
            }
            
        }
    }
}
