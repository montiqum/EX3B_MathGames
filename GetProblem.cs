using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3B_MathGames
{
    class GetProblem
    {
        static Random rand = new Random();
        static int a = 0;
        static int b = 0;

        public static Tuple<int, int> GetNumbers()
        {
            a = rand.Next(1, 13);
            b = rand.Next(1, 13);
            Tuple<int, int> aTuple = Tuple.Create(a, b);

            return aTuple;
        }
    }
}
