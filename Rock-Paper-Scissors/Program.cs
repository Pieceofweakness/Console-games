using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            while (true)
            {
                Console.WriteLine("\nМеню");
                Console.WriteLine("Выберите чем сходить");
                Console.WriteLine("1 - камень");
                Console.WriteLine("2 - ножницы");
                Console.WriteLine("3 - бумага");
                Console.WriteLine("4 - Выход\n");

                int UserChoise = Convert.ToInt32( Console.ReadLine());
                if (UserChoise == 4) break;

                int ComputerChoise = CompChoise();

                if (UserChoise == ComputerChoise)
                {
                    Console.WriteLine("DRAW");
                    continue;
                }

                if (UserChoise  != ComputerChoise)
                {
                    if (UserChoise == 1 && ComputerChoise == 2) Console.WriteLine("YOU WIN");
                    if (UserChoise == 1 && ComputerChoise == 3) Console.WriteLine("YOU LOSE");
                    if (UserChoise == 2 && ComputerChoise == 1) Console.WriteLine("YOU LOSE");
                    if (UserChoise == 2 && ComputerChoise == 3) Console.WriteLine("YOU WIN");
                    if (UserChoise == 3 && ComputerChoise == 1) Console.WriteLine("YOU WIN");
                    if (UserChoise == 3 && ComputerChoise == 2) Console.WriteLine("YOU LOSE");
                    continue;
                }

            }

            int CompChoise()
            {
                return rnd.Next(1,4);
            }



        }
    }
}
