using System;
using System.Collections.Generic;
using System.Text;

/*
 Problem 2: Write a method GenerateQuestion that can be used as a math tutor for a young student. 
The method should generate and display two random numbers that are to be added, such as:
    247
 +129
---------
The method should wait for the student to enter the answer. 
If the answer is correct, the method should return true,otherwise it should return false.
Then, in Main, generate three such questions. For each one, if the user answered correctly (if the method returned true)
then display a "congratulations!" message. Otherwise display a message similar to: "you answered incorrectly, please try again!".
Hint 1: use Random, as seen in class!
Hint 2: see previous notes on how to format the output so it displays the numbers nicely aligned! 
*/

namespace Program_Utilities.Week_1
{
    class GenerateMathProblem
    {

        /* Create a method called GenerateQuestion() that generates two numbers then asks for user input to compare the sum of the
         of the two numbers to the users input. If the input of the user is equal the method returns true, otherwise returns false
         */
        public bool GenerateQuestion()
        {
            Random ranNumber = new Random();
            int tempFirstNumber = ranNumber.Next(1, 1001); // Creates an int and assigns it the first random value
            int tempSecondNumber = ranNumber.Next(1, 1001); // Creates an int and assigns it the second random value
            Console.Write("Here is a math problem to solve! what is {0} + {1}?: ", tempFirstNumber, tempSecondNumber); // Asks user to input the solution as an int
            int tempUserInput = Convert.ToInt32((Console.ReadLine())); // Temporary int to hold the users input
            if (tempUserInput.Equals(tempFirstNumber + tempSecondNumber)) // if statement to check if user input is equal to sum of Randoms
            {
                return true; // sum is equal return true
            }
            else
            {
                return false; // sum is not equal return false
            }

        }

        public void RunMain()
        {
            while (true)
            {
                // The next three statements call the GenerateQuestion() three times in total to prompt the user to answer three different math questions
                Console.WriteLine("Get ready for a math question!");
                if (GenerateQuestion() == true)
                {// checks to see if the GenerateQuestion() method returned true or false
                    Console.WriteLine("congratulations! you answered correctly!"); // prints if user guessed the correct sum of both Randoms
                }
                else
                {
                    Console.WriteLine("Sorry try again, you answered incorrectly!"); // prints if user did not guess the correct sum of both Randoms
                }

                // Repeat of the above statement, asking for user to guess the sum of both Randoms
                Console.WriteLine("Get ready for a math question!");
                if (GenerateQuestion() == true)
                {
                    Console.WriteLine("congratulations! you answered correctly!");
                }
                else
                {
                    Console.WriteLine("Sorry try again, you answered incorrectly!");
                }


                // Repeat of the above statements, asking for user to guess the sum of both Randoms
                Console.WriteLine("Get ready for a math question!");
                if (GenerateQuestion() == true)
                {
                    Console.WriteLine("congratulations! you answered correctly!");
                }
                else
                {
                    Console.WriteLine("Sorry try again, you answered incorrectly!");
                }
                Console.WriteLine("Do you want to use the program again or go to the main menu?, yes or no?");
                string yesNo = Console.ReadLine();
                if (yesNo == "yes")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }
        }

    }
}


