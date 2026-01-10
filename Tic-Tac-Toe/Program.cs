using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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


            Console.WriteLine("GAME TIC_TAC_TOE");
            while (true)
            {
                DisplayMap();

                PlayerStep();
                char result = CheckWin();
                
                if (result != ' ')
                {
                    DisplayMap();
                    ShowResult(result);
                    break;
                }

                Console.WriteLine();
                AIStep();
                result = CheckWin();

                if (result != ' ')
                {
                    DisplayMap();
                    ShowResult(result);
                    break;
                }

            }
            Console.WriteLine("GAME OFF");
            Console.ReadKey();


            void DisplayMap()
            {
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

                if (map[row, col] != 'X' && map[row, col] != 'A')
                {
                    map[row, col] = 'X';
                    return;
                }
                else
                {
                    Console.WriteLine("KLETKA ZANATA");
                }
                

            }

            void AIStep()
            {
                Console.WriteLine("Ход ИИ");

                int app = 0;
                while (app < 100)
                {
                    int choise = rnd.Next(1, 10);
                    int row = (choise - 1) / 3;
                    int col = (choise - 1) % 3;
                    
                    if (map[row, col] != 'X' && map[row, col] != 'A')
                    {
                        map[row, col] = 'A';
                        return;
                    }
                    app++;
                }

                
            }

            DisplayMap();
            PlayerStep();
            DisplayMap();
            AIStep();
            DisplayMap();


            char CheckWin()
            {
                for (int row = 0; row < 3; row++)
                {
                    if ((map[row,0] == map[row,1]) && (map[row, 1] == map[row, 2]) )
                    {
                        return map[row, 0];
                    }
                }

                for(int col = 0; col < 3; col++)
                {
                    if ((map[0,col] == map[1,col]) && (map[1,col] == map[2, col]))
                    {
                        return map[0, col];
                    }
                }

                if ((map[0,0] == map[1,1]) && (map[1,1] == map[2, 2]))
                {
                    return map[0, 0];
                }

                if ((map[0, 2] == map[1, 1]) && (map[1, 1] == map[2, 0]))
                {
                    return map[0, 2];
                }

                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        if (map[row,col] != 'X' && map[row,col] != 'A')
                        {
                            return ' ';
                        }
                        
                    }
                }

                return 'D';

            }

            void ShowResult(char result)
            {
                if (result == 'X')
                {
                    Console.WriteLine("PLAYER WIN");
                }
                if (result == 'A')
                {
                    Console.WriteLine("AI WIN");
                }
                if(result == 'D')
                {
                    Console.WriteLine("DRAW");
                }
            }

        }
    }
}
