using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3B_MathGames
{
    class Compare
    {
        static int count = 0;
        static int quescounter = 0;
        static int inputanswer = 0;
        static double inputanswer2 = 0;
        static bool validInput = false;
        public static void CompareAndCalculate(int noofques, int answer)
        {
            validInput = false;
            
            while (!validInput)
            {
                try
                {
                    inputanswer = Int32.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Invalid Choice. Try Again.");
                    validInput = false;

                }  
                
            }
            if (inputanswer == answer)
            {
                Console.WriteLine("Correct\n");
                count++;
                quescounter++;
            }
            else
            {
                Console.WriteLine($"Sorry, the correct answer is {answer}\n");
                quescounter++;
            }
            if (quescounter == noofques)
            {
                Console.WriteLine($"You got {count} out of {noofques} questions right!");
            }
        }
        public static void CompareAndCalculate(int noofques, double answer)
        {
            validInput = false;

            while (!validInput)
            {
                try
                {
                    inputanswer2 = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
                    validInput = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Invalid Choice. Try Again.");
                    validInput = false;
                }
            }
            if (inputanswer2 == answer || inputanswer2 == answer + 0.01)
            {
                Console.WriteLine("Correct\n");
                count++;
                quescounter++;
            }
            else
            {
                Console.WriteLine($"Sorry, the correct answer is {answer}\n");
                quescounter++;
            }
            if (quescounter == noofques)
            {
                Console.WriteLine($"You got {count} out of {noofques} questions right!");
            }
            
        }
    }
}
