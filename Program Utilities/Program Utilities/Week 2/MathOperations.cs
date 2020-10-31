using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Program_Utilities.Week_2

/*Problem 2: Randomly generate two integers between 1 and 15 inclusively, let's call them a and b. 
* Then randomly generate a number between 1 and 4, call it operation.
If the value of operation is 1, then prompt the user to enter the result of the expression a+b
If the value of operation is 2, then prompt the user to enter the result of the expression a*b
If the value of operation is 3, then prompt the user to enter the result of the expression a-b
If the value of operation is 4, then prompt the user to enter the result of the expression a/b
If the user answers correctly then output a congratulation message, otherwise output a message 
indicating the answer entered was wrong. ask 20 times and output answers to a file
*/

{
    class MathOperations
    {
        public void RunMain()
        {
           StreamWriter OutputTextVersion = new StreamWriter("C:\\Temp\\output.txt");

            try
            {
                 
                while (true)
                {
                    Random Operation = new Random();// Create a new random Object to generate random numbers
                    int twentyGuesses = 20;// Total number of guesses
                    int guessesCorrect = 0;// Total number of guesses correct
                    while (twentyGuesses > 0)
                    {
                        int a = Operation.Next(1, 16);// Int a is  value holder to use during the programs operations on numbers questions 
                        int b = Operation.Next(1, 16);// Int b is  value holder to use during the programs operations on numbers questions 
                        int operation = Operation.Next(1, 5); // Int Operation generates possible choices for expressions the user will need to perform math operations on
                        if (operation == 1) // Checks to see if the user needs to solve an addition problem
                        {
                            Console.Write($"You got a random addition problem! Solve {a} + {b}:");
                            string userInput = Console.ReadLine();// String to hold the user input to allow the 
                            OutputTextVersion.WriteLine($"You got a random addition problem! Solve {a} + {b}:{userInput}");// Writes the same line above to a text file called output.txt
                            if (Convert.ToInt32(userInput).Equals(a + b)) // Checks to see if the user guessed the correct addition value
                            {
                                Console.WriteLine("You Guessed it correctly, fantastic job!");
                                OutputTextVersion.WriteLine("You Guessed it correctly, fantastic job!");// Writes the same line above to a text file called output.txt
                                twentyGuesses = twentyGuesses - 1; // Take away one guessing attempt
                                guessesCorrect = guessesCorrect + 1;// When the user guessed correct increment guessesCorrect variable

                            }
                            else
                            {
                                Console.WriteLine("Well college loans don't look so bad right now, time to school up! Your answer was incorrect");
                                OutputTextVersion.WriteLine("Well college loans don't look so bad right now, time to school up! Your answer was incorrect");// Writes the same line above to a text file called output.txt
                                twentyGuesses = twentyGuesses - 1; // Take away one guessing attempt
                            }
                        }
                        else if ((operation == 2)) // Checks to see if the user needs to solve a multiplication problem
                        {
                            Console.Write($"You got a random multiplication problem! Solve {a} * {b}:");
                            string userInput = Console.ReadLine();
                            OutputTextVersion.WriteLine($"You got a random multiplication problem! Solve {a} * {b}:{userInput}");
                            if (Convert.ToInt32(userInput).Equals(a * b)) // Checks to see if the user guessed the correct multiplication value
                            {
                                Console.WriteLine("You Guessed it correctly, fantastic job!");
                                OutputTextVersion.WriteLine("You Guessed it correctly, fantastic job!");// Writes the same line above to a text file called output.txt
                                twentyGuesses = twentyGuesses - 1; // Take away one guessing attempt
                                guessesCorrect = guessesCorrect + 1;// When the user guessed correct increment guesses Correct variable
                            }
                            else
                            {
                                Console.WriteLine("Well college loans don't look so bad right now, time to school up! Your answer was incorrect");
                                OutputTextVersion.WriteLine("You Guessed it correctly, fantastic job!");// Writes the same line above to a text file called output.txt
                                twentyGuesses = twentyGuesses - 1; // Take away one guessing attempt
                            }
                        }
                        else if ((operation == 3))// Checks to see if the user needs to solve a subtraction problem
                        {
                            Console.Write($"You got a random subtraction problem! Solve {a} - {b}:");
                            string userInput = Console.ReadLine();
                            OutputTextVersion.WriteLine($"You got a random subtraction problem! Solve {a} - {b}:{userInput}");// Writes the same line above to a text file called output.txt
                            if (Convert.ToInt32(userInput).Equals(a - b)) // Checks to see if the user guessed the correct multiplication value
                            {
                                Console.WriteLine("You Guessed it correctly, fantastic job!");
                                OutputTextVersion.WriteLine("You Guessed it correctly, fantastic job!");// Writes the same line above to a text file called output.txt
                                twentyGuesses = twentyGuesses - 1; // Take away one guessing attempt
                                guessesCorrect = guessesCorrect + 1;// When the user guessed correct increment guesses Correct variable
                            }
                            else
                            {
                                Console.WriteLine("Well college loans don't look so bad right now, time to school up! Your answer was incorrect");
                                OutputTextVersion.WriteLine("Well college loans don't look so bad right now, time to school up! Your answer was incorrect");// Writes the same line above to a text file called output.txt
                                twentyGuesses = twentyGuesses - 1; // Take away one guessing attempt
                            }
                        }
                        else // Checks to see if the user needs to solve a division problem
                        {
                            Console.Write($"You got a random division problem! Solve {a} \\ {b}:");
                            string userInput = Console.ReadLine();
                            OutputTextVersion.WriteLine($"You got a random division problem! Solve {a} \\ {b}:{userInput}");// Writes the same line above to a text file called output.txt
                            if (Convert.ToInt32(userInput).Equals(a / b)) // Checks to see if the user guessed the correct division value
                            {
                                Console.WriteLine("You Guessed it correctly, fantastic job!");
                                OutputTextVersion.WriteLine("You Guessed it correctly, fantastic job!");// Writes the same line above to a text file called output.txt
                                twentyGuesses = twentyGuesses - 1; // Take away one guessing attempt
                                guessesCorrect = guessesCorrect + 1;// When the user guessed correct increment guesses Correct variable
                            }
                            else
                            {
                                Console.WriteLine("Well college loans don't look so bad right now, time to school up! Your answer was incorrect");
                                OutputTextVersion.WriteLine("Well college loans don't look so bad right now, time to school up! Your answer was incorrect");// Writes the same line above to a text file called output.txt
                                twentyGuesses = twentyGuesses - 1; // Take away one guessing attempt
                            }
                        }
                    }
                    Console.WriteLine($"Man you were really cracking away! You guessed {guessesCorrect} correct out of 20 attempts");
                    OutputTextVersion.WriteLine($"Man you were really cracking away! You guessed {guessesCorrect} correct out of 20 attempts");// Writes the same line above to a text file called output.txt
                    OutputTextVersion.Close();
                    Console.WriteLine("Do you want to use the program again or go to the main menu?, yes or no?");
                    string yesNo = Console.ReadLine();
                    if (yesNo == "yes")
                    {
                        OutputTextVersion.Close();
                        continue;
                    }
                    else
                    {
                        OutputTextVersion.Close();
                        break;
                    }
                   

                }
                OutputTextVersion.Close();
            }
            catch (Exception e)
            {
                OutputTextVersion.Close();
                Console.WriteLine("You did not input a correct type for an answer please try again");

            }

        }
    }
}
