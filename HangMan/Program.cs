using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    internal class Program
    {
         
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] words = {"попа","софия","матвей","автобус"};
            Console.WriteLine("COMP ZAGADAL SLOVO");

            string ZagadanoeSlovo = words[rnd.Next(words.Length)];

            char[] display = new char[ZagadanoeSlovo.Length];

            for (int i = 0; i < ZagadanoeSlovo.Length; i++)
            {
                display[i] = '_';
            }

            List<Char> bukvi = new List<char>(); 

            while (true)
            {
                //Console.WriteLine(ZagadanoeSlovo);
                Console.WriteLine($"Слово: {string.Join(" ", display)}\n");
                Console.WriteLine("VVEDITE BUKVU\n");

                char UserBukva = Convert.ToChar(Console.ReadLine());

                if (bukvi.Contains(UserBukva))
                {
                    Console.WriteLine("BUKVA BILA\n");
                    continue;
                }
                bukvi.Add(UserBukva);


                for (int i = 0; i < ZagadanoeSlovo.Length; i++)
                {
                    if (ZagadanoeSlovo[i] == UserBukva)
                    {
                        display[i] = UserBukva;
                    }
                }

                if (!display.Contains('_'))
                {
                    Console.WriteLine("POBEDA\n");
                    break;
                }
                


            }

        }
    }
}
