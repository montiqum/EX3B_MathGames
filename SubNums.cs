using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3B_MathGames
{
    class SubNums
    {
        static int answer = 0;
        static int a = 0, b = 0;
        public static void Subtraction(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                a = GetProblem.GetNumbers().Item1;
                b = GetProblem.GetNumbers().Item2;
                if(a >= b)
                {
                    answer = a - b;
                    Console.Write($"{i}. {a} - {b} = ");
                }
                else
                {
                    answer = b - a;
                    Console.Write($"{i}. {b} - {a} = ");
                }          
                Compare.CompareAndCalculate(n, answer);
            }
        }
    }
}
