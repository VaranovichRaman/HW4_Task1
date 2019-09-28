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
        public static void GameStart()
        {
            Initial_Data.SetPlayersNames(Initial_Data.SetNumberOfPlayers());
        }
         public static void GameMenu(string[] playersList, int numberOfPlayers)
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
                    for (int i = 0; i < playersList.Length; i++)
                    {
                        Console.WriteLine($"Player {i + 1}: {playersList[i]};");
                    }
                }
                else if (choose == "h")
                {
                    Initial_Data.ShowHistory();
                }
                else
                {
                    PlayerSelection(playersList, numberOfPlayers);
                }
            }
        }
        public static void PlayerSelection(string[] list, int numberOfPlayers)
        {
            Random random = new Random();
            string activePlayer = list[random.Next(list.Length - 1)];
            Console.WriteLine($"The next quest will be done by {activePlayer}, and here’s the quest:\n");
            Initial_Data.Quests(activePlayer);
        }
    }
}
