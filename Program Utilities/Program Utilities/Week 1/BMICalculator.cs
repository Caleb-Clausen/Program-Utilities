using System;
using System.Collections.Generic;
using System.Text;

namespace Program_Utilities.Week_1
{
    /*Problem 1: Write a C# program that calculates and displays a person's body mass index (BMI).
The BMI is often used to determine whether a person with a sedentary lifestyle is overweight, or 
is underweight. A person's BMI is calculated with the following formula:
BMI = weight * 703/ height2 where weight is measured in pounds and height is measured in inches. 
The program ask the user to enter values for weight and height. 
Then it should display the person's BMI and a message indicating whether the person has optimal weight, is underweight, or is overweight.
A sedentary person's weight is considered to be optimal if his or her BMI is between 18.5 and 25 (inclusively). 
If the BMI is less than 18.5, the person is considered to be underweight. If the BMI value is greater than 25, the 
person is considered to be overweight.
*/

    class BMICalculator
    {
        public double calculatorBodyMassIndex(double weight, double height) // Declares a method called calculatorBodyMassIndex() that accepts two doubles to compute a person’s BMI
        {
            return (weight * 703 / (Math.Pow(height, 2))); // Uses the formula provided to calculate the users inputs and returns their BMI
        }


       public void RunMain()
        {
            
            while (true)// While loop to do many tests and keep asking for input
            {
                // Console.WriteLine("Welcome to the Body Mass Index Calculator!");
                Console.Write("Please input your current weight: ");
                double tempWeight = Convert.ToDouble(Console.ReadLine()); // Takes the console input for users Height and stores it for later use
                Console.Write("Please input your current height: ");
                double tempHeight = Convert.ToDouble(Console.ReadLine());// Takes the console input for users Weight and stores it for later use
                double tempBodyMassIndex = calculatorBodyMassIndex(tempWeight, tempHeight); // Calculates the console input for users Weight and stores it for later use to minimize code length
                if (tempBodyMassIndex >= 18.5 && tempBodyMassIndex <= 25)// Checking the first condition to see if the user is in the optimal BMI range
                {
                    Console.WriteLine("Your BMI is {0:F2} and since you fall between 18.5 and 25 it is optimal!", tempBodyMassIndex);
                }
                else if (tempBodyMassIndex < 18.5) // Checking the second condition to see if the user is below the optimal BMI range
                {
                    Console.WriteLine("Your BMI is {0:F2} and since you fall below 18.5, it is too low, you need to up it!", tempBodyMassIndex);
                }
                else// As both conditions have been checked, prints out that the user is above the optimal BMI range.
                {
                    Console.WriteLine("Your BMI is {0:F2} and since you are above 25, it is too high, get some hiking in!", tempBodyMassIndex);
                }

                Console.WriteLine("Do you want to use the program again or go to the main menu?, yes or no?");
                string yesNo = Console.ReadLine();
                if(yesNo == "yes")
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



