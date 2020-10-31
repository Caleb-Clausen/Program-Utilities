using System;
using System.Collections.Generic;
using System.Text;

/*Problem 3: If you are given three sticks, you may or may not be able to arrange them in a triangle.
 For example, if one of the sticks is 12 inches long and the other two are one inch long, 
you will not be able to get the short sticks to meet in the middle. For any three lengths, 
there is a simple test to see if it is possible to form a triangle:
     "If any of the three lengths is greater than the sum of the other two, then you cannot form a triangle. Otherwise, you can."
Write a method named IsTriangle that takes three integers as arguments, and returns either true or false, 
depending on whether you can or cannot form a triangle from sticks with the given lengths.  
Test your IsTriangle method in Main().
*/


namespace Program_Utilities.Week_1
{
    class IsTriangle
    {

        /* Creates a method called IsTriangle() that accepts three different int's each representing a side of a triangle
         * Then tests to see if any of the one side is bigger than the other two sides sum. If they are then it returns false
         * If the sum of all two sides is greater than any one side it returns true
          */
        public bool IsTriangleThreeSides(int firstStick, int secondstick, int thirdStick)
        {
            if (thirdStick > (firstStick + secondstick)) // Tests to see if the first stick and second stick length sum total are greater than the length of the third stick
            {
                return false;
            }
            else if (secondstick > (firstStick + thirdStick)) // Tests to see if the first stick and third stick length sum total are greater than the length of the second stick
            {
                return false;
            }
            else if (firstStick > (secondstick + thirdStick)) // Tests to see if the second stick and third stick length sum total are greater than the length of the first stick
            {
                return false;
            }
            else return true; // returns true if all three sticks can make a triangle
        }
        public void RunMain()
        {
            while (true)
            {
                Console.WriteLine("Testing that values(1, 1, 1) are a triangle result:{0}", IsTriangleThreeSides(1, 1, 1));// Tests all three sticks and should come at as true
                Console.WriteLine("Testing that values(2, 1, 1) are a triangle result:{0}", IsTriangleThreeSides(2, 1, 1));// Tests all three sticks and should come at as true
                Console.WriteLine("Testing that values(1, 4, 1) are a triangle result:{0}", IsTriangleThreeSides(1, 4, 1));// Tests all three sticks and should come at as false
                Console.WriteLine("Testing that values(1, 1, 3) are a triangle result:{0}", IsTriangleThreeSides(1, 1, 3));// Tests all three sticks and should come at as false
                Console.WriteLine("Testing that values(4, 1, 3) are a triangle result:{0}", IsTriangleThreeSides(4, 1, 3));// Tests all three sticks and should come at as true
                Console.WriteLine("Testing that values(10, 1, 3) are a triangle result:{0}", IsTriangleThreeSides(10, 1, 3));// Tests all three sticks and should come at as false
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

