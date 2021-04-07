using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3B_MathGames
{
    class AddNums
    {      
        static int answer = 0;
        static int a = 0, b = 0;
        public static void Addition(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                a = GetProblem.GetNumbers().Item1;
                b = GetProblem.GetNumbers().Item2;
                answer = a + b;

                Console.Write($"{i}. {a} + {b} = ");               
                Compare.CompareAndCalculate(n, answer);
            }
        }
    }
}
