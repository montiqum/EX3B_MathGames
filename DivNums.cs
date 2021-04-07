using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3B_MathGames
{
    class DivNums
    {
        static double answer = 0;
        static int a = 0, b = 0;
        public static void Division(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                a = GetProblem.GetNumbers().Item1;
                b = GetProblem.GetNumbers().Item2;
                answer = Math.Round((Convert.ToDouble(a) / Convert.ToDouble(b)), 2);

                Console.Write($"{i}. {a} / {b} = ");
                Compare.CompareAndCalculate(n, answer);
            }
        }
    }
}
