using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW4_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //History();
            //ReadFromFile();
            var length = NumberOfPlayers();

            PlayersNames(length);

            

        }

        static int NumberOfPlayers()
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

        static void PlayersNames(int number)
        {

            string[] playersList = new string[number];

            Console.WriteLine($"\nEnter the name of each player, separating them with the \"Enter\" key.\n");

            for (int i = 0; i < playersList.Length; i++)
            {
                playersList[i] = Console.ReadLine();
            }

            Console.WriteLine($"\nOk, all players are here, let's start!\n");

            GameMenu(playersList, number);

        }

        static void GameMenu(string[] list, int number)
        {
            while (true)
            {

                Console.WriteLine($"\nType q - for exit, p - for display the list of players, other input - play round.\n");

                string choose = Console.ReadLine();

                if (choose == "q")
                {
                    Console.WriteLine($"Goodbye!");

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
                else
                {
                    GameStart(list, number);
                }
            }
        }

        static void GameStart(string[] list, int numberOfPlayers)
        {
            Random random = new Random();

            Console.WriteLine($"The next quest will be done by {list[random.Next(list.Length - 1)]}, and here’s the quest:\n");

            Quests();

        }

        static void Quests()
        {
            string[] mas = new string[20];

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = $"Drink {i} shot(s)";
            }

            Random rand = new Random();

            Console.WriteLine($"\n{mas[rand.Next(mas.Length)]}\nPress the Enter key when completing the task\n");

            Console.ReadLine();

        }

        //static void ReadFromFile()
        //{
        //    string path = @"D:\quests.txt";

        //    try
        //    {
        //        using (StreamReader read = new StreamReader(path, Encoding.Default))
        //        {
        //            string line;
        //            while ((line = read.ReadLine()) != null)
        //            {
        //                Console.WriteLine(line);
        //            }
        //        }

        //        Console.ReadLine();
        //        Console.WriteLine();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }
        //}

        //static void History()
        //{
        //    string historyFilePath = @"D:\history.txt";

        //    try
        //    {
        //        using (StreamWriter sw = new StreamWriter(historyFilePath, true, Encoding.Default))
        //        {
        //            sw.WriteLine("NewQuest");                   
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //    Console.ReadLine();
        //}
    }
}
