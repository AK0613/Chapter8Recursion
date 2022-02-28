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
                        /*case 2:
                            p2();
                            break;
                        case 3:
                            p3();
                            break;
                            case 5:
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


        #region Menu
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
        #endregion

        #region Problems

        private static void P1()
        {
            int numOfSteps;
            string? input;
            bool valid;

            Console.Clear();
            Console.WriteLine("Problem 1: A child is running up a staircase with n steps and can hop either 1, 2, or 3, steps at a time. Implement a method to count how many possible ways the child can run up the stairs");

            do
            {
                Console.Write("Enter an integer value for n: ");
                input = Console.ReadLine();

                valid = int.TryParse(input, out numOfSteps);

                if (!valid)
                    Console.WriteLine("Invalid input.");

            } while (!valid);

            Console.WriteLine("The result is: ");
            int numSteps = Steps(numOfSteps);
            Console.WriteLine(numSteps);

        }

        static int Steps(int n)
        {
            if (n < 0)
                return 0;
            else if (n == 0)
                return 1;
            else
                return Steps(n-1) + Steps(n-2) + Steps(n-3);    
        }
        #endregion
    }
}