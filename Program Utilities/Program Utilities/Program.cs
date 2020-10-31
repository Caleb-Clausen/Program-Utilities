using Program_Utilities.Week_1;
using Program_Utilities.Week_2;
using System;

namespace Program_Utilities
{
    class Program
    {
        static void Main(string[] args)
        {
            BMICalculator testBMI = new BMICalculator();
            GenerateMathProblem testMath = new GenerateMathProblem();
            IsTriangle testIsTriangle = new IsTriangle();
            MathOperations testMathOperations = new MathOperations();
            SalesAsAsterisks testSalesAsAsterisks = new SalesAsAsterisks();
            int userChoice;
            while (true)
            {
                Console.WriteLine("Please choose one of the following numbers to test each program");
                Console.WriteLine(" 1. BMI Calculator\n 2. Generate Math Problem\n 3. Check three lengths for Triangle" +
                    " \n 4. Perform the four basic math operations \n 5. Show business sales as Asterisks");
                try
                {
                    userChoice = Convert.ToInt32(Console.ReadLine());
                    if (userChoice < 1 || userChoice > 10)
                    {
                        Console.WriteLine("You did not input a correct choice or option, try again");
                        continue;
                    }
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine("You did not input a correct choice or option, try again");
                    continue;
                }


                switch (userChoice)
                {
                    case 1:
                        testBMI.RunMain();
                        break;
                    case 2:
                        testMath.RunMain();
                        break;
                    case 3:
                        testIsTriangle.RunMain();
                        break;
                    case 4:
                        testMathOperations.RunMain();
                        break;
                    case 5:
                        testSalesAsAsterisks.RunMain();
                        break;


                }


            }




        }
    }
}

