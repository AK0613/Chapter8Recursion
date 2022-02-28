using System;

namespace Chapter8Recursion
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? choice;
            int problem;

            Console.WriteLine("Problems from the book. Chapter 8: Recursion");

            do
            {
                problem = Menu();
                switch (problem)
                {
                    case 1:
                        P1();
                        break;
                    case 2:
                        p2();
                        break;
                    case 3:
                        p3();
                        break;
                        /*case 5:
                            p5();
                            break;
                        case 6:
                            p6();
                            break;
                        case 7:
                            p7();
                            break;
                        case 8:
                            p8();
                            break;
                        case 9:
                            p9();
                            break;*/
                }


                Console.WriteLine("Would you like to try another problem? (Enter y or Y to proceed)");

                choice = Console.ReadLine();

            } while (choice == "y" || choice == "Y");
        }

        private static void P1()
        {
            throw new NotImplementedException();
        }

        static int Menu()
        {
            string? input;
            int problem;
            bool valid;

            Console.Clear();
            Console.WriteLine("Problem 1: A child is running up a staircase with n steps and can hop either 1, 2, or 3, steps at a time. Implement a method to count how many possible ways the child can run up the stairs\n" +
                "");

            do
            {
                Console.WriteLine("Please enter a number to select a problem: ");
                input = Console.ReadLine();
                valid = int.TryParse(input, out problem);
                if (!valid || problem > 10 || problem < 0)
                {
                    Console.WriteLine("Invalid input. You entered {0}", input);
                }

            } while (!valid || problem > 10 || problem < 0);

            return problem;
        }
    }
}