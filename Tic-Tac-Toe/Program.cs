using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            char[,] map = new char[3,3];
            char cellNum = '1';
            for(int row = 0; row < 3; row++)
            {
                for(int col = 0; col < 3; col++)
                {
                    map[row, col] = cellNum;
                    cellNum++;
                }
            }

            void DisplayMap()
            {
                Console.WriteLine("\n     КРЕСТИКИ-НОЛИКИ");
                Console.WriteLine("   ———————————");

                for (int row = 0; row < 3; row++)
                {
                    Console.Write("   ");
                    for (int col = 0; col < 3; col++)
                    {
                        Console.Write($" {map[row, col]} ");
                        if (col < 2) Console.Write("|");
                    }
                    Console.WriteLine();

                    if (row < 2)
                        Console.WriteLine("   ———|———|———");
                }
                Console.WriteLine();
            }
            

            void PlayerStep()
            {
                Console.WriteLine("Ваш ход - выбери номер клетки");
                char choice = Convert.ToChar( Console.ReadLine());

                int row = 0;
                int col = 0;

                switch (choice)
                {
                    case '1':
                        row = 0;
                        col = 0;
                        break;
                    case '2':
                        row = 0;
                        col = 1;
                        break;
                    case '3':
                        row = 0;
                        col = 2;
                        break;
                    case '4':
                        row = 1;
                        col = 0;
                        break;
                    case '5':
                        row = 1;
                        col = 1;
                        break;
                    case '6':
                        row = 1;
                        col = 2;
                        break;
                    case '7':
                        row = 2;
                        col = 0;
                        break;
                    case '8':
                        row = 2;
                        col = 1;
                        break;
                    case '9':
                        row = 2;
                        col = 2;
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }


                map[row,col] = 'X';

            }

            void AIStep()
            {
                Console.WriteLine("Ход ИИ");
                char choice = '2';

                int row = 0;
                int col = 0;

                switch (choice)
                {
                    case '1':
                        row = 0;
                        col = 0;
                        break;
                    case '2':
                        row = 0;
                        col = 1;
                        break;
                    case '3':
                        row = 0;
                        col = 2;
                        break;
                    case '4':
                        row = 1;
                        col = 0;
                        break;
                    case '5':
                        row = 1;
                        col = 1;
                        break;
                    case '6':
                        row = 1;
                        col = 2;
                        break;
                    case '7':
                        row = 2;
                        col = 0;
                        break;
                    case '8':
                        row = 2;
                        col = 1;
                        break;
                    case '9':
                        row = 2;
                        col = 2;
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }


                map[row, col] = '0';
            }

            DisplayMap();
            PlayerStep();
            DisplayMap();
            AIStep();
            DisplayMap();

        }
    }
}
