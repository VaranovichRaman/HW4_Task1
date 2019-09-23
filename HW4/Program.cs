using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = NumberOfPlayers();

            PlayersNames(length);

            Console.ReadLine();
        }

        static int NumberOfPlayers()
        {
            bool flag = true;

            int count = 0;

            Console.WriteLine($"Welcome to the game \"Funny quests\" ! Please select number of players from 2 to 10 players.");

            while (flag)
            {
                bool check = Int32.TryParse(Console.ReadLine(), out count);
                if ( count > 1 && count < 11 )
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

            Console.WriteLine($"Enter the name of each player, separating them with the \"Enter\" key.");

            for (int i = 0; i < playersList.Length; i++)
            {
                playersList[i] = Console.ReadLine();
            }

            foreach (var item in playersList)
            {
                Console.Write(item + " ");
            }

        }
    }
}
