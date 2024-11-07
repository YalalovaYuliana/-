using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 // check random
{
    internal class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {

            int orel = 0;
            int reshka = 0;            

            for (int i = 0; i < 50; i++)
            {
                if (TossACoin()) orel++;
                else reshka++;
                Console.WriteLine(rand.Next(0, 2));

            }

            Console.WriteLine(orel + " " + reshka);

        }

        static bool TossACoin() => rand.Next(0, 2) == 0 ? false : true;
    }
}
