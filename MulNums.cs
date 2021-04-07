using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3B_MathGames
{
    class MulNums
    {
        static int answer = 0;
        static int a = 0, b = 0;
        public static void Multiplication(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                a = GetProblem.GetNumbers().Item1;
                b = GetProblem.GetNumbers().Item2;
                answer = a * b;

                Console.Write($"{i}. {a} x {b} = ");
                Compare.CompareAndCalculate(n, answer);
            }
        }
    }
}
