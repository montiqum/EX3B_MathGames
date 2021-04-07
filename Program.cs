using System;

namespace EX3B_MathGames
{
    class Program
    {
        static int game = 0;
        static int p = 0;

        public static void MathGames()
        {           
            Console.WriteLine("What game do you want to play?");
            Console.WriteLine("Addition - 1\nSubtraction - 2");
            Console.WriteLine("Multiplication - 3\nDivision - 4");
            while (game < 1 || game > 4)
            {
                try
                {
                    game = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    game = 0;
                }
                if (game >= 1 && game <= 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice. Try Again.");
                }
                
            } 
            Console.WriteLine("How many problems? (1 - 12)");

            while (p < 1 || p > 12)
            {
                try
                {
                    p = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    p = 0;
                }
                if (p >= 1 && p <= 12)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice. Try Again.");
                }
            }
            switch (game)
            {
                case 1:
                    Setup.PrintInfo(game, p);
                    AddNums.Addition(p);    
                    break;

                case 2:
                    Setup.PrintInfo(game, p);
                    SubNums.Subtraction(p);
                    break;

                case 3:
                    Setup.PrintInfo(game, p);
                    MulNums.Multiplication(p);
                    break;

                case 4:
                    Setup.PrintInfo(game, p);
                    DivNums.Division(p);
                    break;

                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
        static void Main(string[] args)
        {
            MathGames();
        }
    }
}
