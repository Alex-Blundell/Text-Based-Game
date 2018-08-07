using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int Health;
            int Mana;
            string uName;
            int MenuIndex = 0;
            int Index = 0;

            while (Index == 0)
            {
                Console.WriteLine("\n1. Start New Game");
                Console.WriteLine("2. Load Game");
                Console.WriteLine("3. Exit\n");
                Console.Write(":");

                MenuIndex = Convert.ToInt32(Console.ReadLine());

                if (MenuIndex == 1)
                {
                    Index = 1;
                }
                else if (MenuIndex == 2)
                {
                    Index = 2;
                }
                else if (MenuIndex == 3)
                {
                    // Close Application
                }
                else
                {
                    Console.Clear();
                }
            }

            Console.ReadKey();
        }
    }
}
