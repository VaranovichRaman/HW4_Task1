using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW4_Task1;

namespace HW4
{
    class Initial_Data
    {
        public static int NumberOfPlayers()
        {
            bool flag = true;
            int count = 0;
            Console.WriteLine($"Welcome to the game \"Funny quests\" ! Please select number of players from 2 to 10 players.");
            while (flag)
            {
                bool check = Int32.TryParse(Console.ReadLine(), out count);
                if (count > 1 && count < 11 && check == true)
                {
                    Console.WriteLine($"Great, this is the most optimal number of players!");
                    flag = false;
                }
                else
                {
                    Console.WriteLine($"Wrong number of players, please select from 2 to 10 players.");
                }
            }

            return count;
        }

        public static void PlayersNames(int number)
        {
            string[] playersList = new string[number];
            Console.WriteLine($"\nEnter the name of each player, separating them with the \"Enter\" key.\n");
            for (int i = 0; i < playersList.Length; i++)
            {
                playersList[i] = Console.ReadLine();
            }

            Console.WriteLine($"\nOk, all players are here, let's start!\n");
            Menu.GameMenu(playersList, number);
        }
        public static void Quests(string activePlayer)
        {
            string[] quests = File.ReadAllLines("../../questsList.txt", Encoding.Default);
            Random rand = new Random();
            string randomQuest = quests[rand.Next(quests.Length)];
            Console.WriteLine($"\n{randomQuest}\nPress the Enter key when completing the task\n");
            History(activePlayer, randomQuest);
            Console.ReadLine();
        }

        public static void History(string activePlayer, string randomQuest)
        {
            string appendText = $"{activePlayer} completed the quest: \"{randomQuest}\"" + Environment.NewLine;
            File.AppendAllText("../../history.txt", appendText, Encoding.UTF8);
        }

        public static void ShowHistory()
        {
            using (StreamReader readHistory = new StreamReader("../../history.txt"))
            {                
                string historyList = readHistory.ReadToEnd();
                Console.WriteLine(historyList);
            }
        }
    }
}

