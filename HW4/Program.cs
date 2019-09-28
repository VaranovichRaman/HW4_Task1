using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HW4;

namespace HW4_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = Initial_Data.NumberOfPlayers();
            Initial_Data.PlayersNames(length);               
        }  
    }
}
