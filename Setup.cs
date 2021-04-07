using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3B_MathGames
{
    class Setup
    {
        static string type = " ";
        public static void PrintInfo(int n, int p)
        {
            if (n == 1)
            {
                type = "Addition";
            }
            else if (n == 2)
            {
                type = "Subtraction";
            }
            else if (n == 3)
            {
                type = "Multiplication";
            }
            else if (n == 4)
            {
                type = "Division";
            }
            Console.WriteLine($"You are testing {type} and you have {p} problems");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
