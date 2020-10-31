using System;
using System.Collections.Generic;
using System.Text;
/*Problem 1: Create a method, DisplayAsterisks, what will have an int parameter, num, 
 and will display num asterisks in one line. For example, DisplayAsterisks(5)  should display *****. Similarly, 
 DisplayAsterisks(12)  should display ************. 
 Then, in Main, ask the user to enter the sales values for five stores and, for each one, 
 display a row of asterisks such that each asterisk represents $100 of sales. 
 Make sure to format the output so it matches the sample below.


 Here is an example of the program's output (bolded text represents user's input):

 Enter today's sales for store 1: 1000 [enter]
 Enter today's sales for store 2: 800 [enter]
 Enter today's sales for store 3: 500 [enter]
 Enter today's sales for store 4: 1200 [enter]
 Enter today's sales for store 5: 300 [enter]

 SALES BAR CHART
 (Each * = $100)
 Store 1: **********
 Store 2: ********
 Store 3: *****
 Store 4: ************
 Store 5: ***
*/

namespace Program_Utilities.Week_2
{
    class SalesAsAsterisks
    {

        public void DisplayAsterisks(int money)
        {
            StringBuilder asteriskTotal = new StringBuilder();// Declare a StringBuilder object to add asterisk's to itself per 100 sum
            while (money >= 100)// Small while loop to keep adding asterisk's while the money variable is above 100
            {
                asteriskTotal.Append("*"); // Adding one asterisk per loop
                money = money - 100; // Tracking the total user input and subtracting 100 for each loop
            }
            Console.WriteLine(asteriskTotal); // Writes the final amount of asterisks after the while loop finishes
        }
        public void RunMain()
        {
            while (true) { 
            int fiveStorePrint = 0; // Stores the count for tracking purposes for each store
            string[] storeUserValues = new string[5]; // Declare a String array to hold the five user inputs
            while (fiveStorePrint < 5) // First while loop in main to prompt the user to enter sales for each store
            {
                Console.Write("Enter today's sales for store {0}:", fiveStorePrint + 1);
                storeUserValues[fiveStorePrint] = Console.ReadLine(); // Add's user input to the array storeUserValues
                fiveStorePrint = fiveStorePrint + 1; // While loop breaker

            }
            Console.WriteLine(""); // The following three lines are strings to show information about the sales chart
            Console.WriteLine("SALES BAR CHART");
            Console.WriteLine("(Each * = $100)");
            fiveStorePrint = 0;
            while (fiveStorePrint < 5)// While loop to output the asterisk, calls the DisplayAsterisks() five times
            {
                Console.Write("Store {0}:", fiveStorePrint + 1);
                DisplayAsterisks(Convert.ToInt32(storeUserValues[fiveStorePrint]));// Calling the DisplayAsterisks() using all input from the string array storeUserValues[]
                fiveStorePrint = fiveStorePrint + 1; //While loop breaker
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


