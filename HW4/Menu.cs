using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW4_Task1;

namespace HW4
{
    class Menu
    {
         public static void GameMenu(string[] list, int number)
        {
            while (true)
            {

                Console.WriteLine($"\nType q - for exit, p - for display the list of players, h - for show history, other input - play round.\n");

                string choose = Console.ReadLine();

                if (choose == "q")
                {
                    Console.WriteLine($"Goodbye!");

                    File.Delete("../../history.txt");

                    Console.ReadLine();

                    return;
                }
                else if (choose == "p")
                {

                    for (int i = 0; i < list.Length; i++)
                    {

                        Console.WriteLine($"Player {i + 1}: {list[i]};");

                    }

                }
                else if (choose == "h")
                {
                    Initial_Data.ShowHistory();
                }
                else
                {
                    
                   GameStart(list, number);
                }
            }
        }
        public static void GameStart(string[] list, int numberOfPlayers)
        {
            Random random = new Random();
            string activePlayer = list[random.Next(list.Length - 1)];

            Console.WriteLine($"The next quest will be done by {activePlayer}, and here’s the quest:\n");

            Initial_Data.Quests(activePlayer);

        }


    }
}
