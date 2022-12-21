using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int PlayerPosition=0;
            Console.WriteLine("lets play! \nPlayerPosition=" +PlayerPosition);

            Random random = new Random();
            int Dice = random.Next(1, 7);
            Console.WriteLine("after die rolles the number =" + Dice);
            
            Console.ReadLine();
        }
    }
}
