using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int GuessNumber = rnd.Next(1,101);

            int Attempts = 0;
            Console.WriteLine(GuessNumber);
            while (true)
            {
                int UserChislo = Convert.ToInt32(Console.ReadLine());

                if (UserChislo == GuessNumber)
                {
                    Attempts += 1;
                    Console.WriteLine($"WIN {Attempts}");
                    break;
                }
                else if(UserChislo > GuessNumber)
                {
                    Console.WriteLine($"LOSE >");
                    Attempts += 1;
                    continue;
                }
                else if (UserChislo < GuessNumber)
                {
                    Console.WriteLine($"LOSE <");
                    Attempts += 1;
                    continue;
                }
            }



        }
    }
}
