using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Igrice
{
    class Result
    {
        public static void writeResult(Player player1, Player player2)
        {
            try
            {
                StreamWriter sw = new StreamWriter("D:\\Programiranje\\c#\\Igrice\\result\\" + player1.getName()
                    + "-" + player2.getName() + ".txt", append: true);

                if(player1.getHp() <= 0)
                {
                    sw.WriteLine(player1.getName() + " 0");
                    sw.WriteLine(player2.getName() + " 1");
                }
                else
                {
                    sw.WriteLine(player1.getName() + " 1");
                    sw.WriteLine(player2.getName() + " 0");
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        public static void ReadResult(Player player1, Player player2)
        {
            try
            {
                using (var sr = new StreamReader("D:\\Programiranje\\c#\\Igrice\\result\\" + player1.getName() + "-" + player2.getName() + ".txt"))
                {
                    string[] result = new string[2];
                    string line = "";
                    while((line = sr.ReadLine()) != null)
                    {
                        result = line.Split(" ");
                        if(result[1] == "1")
                        {
                            if(result[0] == player1.getName())
                            {
                                player1.addWin();
                            }
                            else
                            {
                                player2.addWin();
                            }
                        }
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("New battle has started");
            }

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("[" + player1.getName() + "] " + player1.getWins() + " - "
                + player2.getWins() + " [" + player2.getName() + "]");
            Console.WriteLine("----------------------------------------------------------------");
        }
    }
}
