using System;
using System.ComponentModel;

namespace ComputationalThinkingExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("COMPUTATIONAL THINKING EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Are These Integers Equal?");
                Console.WriteLine("2. Even or Odd?");
                Console.WriteLine("3. Vowel or Consonant?");
                Console.WriteLine("4. Find the Largest Number");
                Console.WriteLine("5. Divisible by 3");
                Console.WriteLine("6. Restaurant Bill");
                Console.WriteLine("7. Age Category");
                Console.WriteLine("8. Words to Digits");
                Console.WriteLine("9. Which Name is Longer?");
                Console.WriteLine("10. Are these Numbers the Same?");
                Console.WriteLine("11. Name and Place of Birth");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        AreTheseIntegersEqual();
                        break;
                    case "2":
                        EvenOrOdd();
                        break;
                    case "3":
                        VowelOrConsonant();
                        break;
                    case "4":
                        FindLargestNumber();
                        break;
                    case "5":
                        DivisibleBy3();
                        break;
                    case "6":
                        RestaurantBill();
                        break;
                    case "7":
                        AgeCategory();
                        break;
                    case "8":
                        WordsToDigits();
                        break;
                    case "9":
                        WhichNameIsLonger();
                        break;
                    case "10":
                        AreNamesSame();
                        break;
                    case "11":
                        NameAndBirthplace();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void AreTheseIntegersEqual()
        {
            // Write a console application to ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");

            Console.WriteLine("I'm looking to compare two numbers. May I have a number,please?");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cool. May I have another?");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber == secondNumber)
            {
                Console.WriteLine("Your numbers...MATCH! Tonight, we feast!!!");
            }
            else
            {
                Console.WriteLine("Your numbers are not equal. This ...disappoints me.");
            }
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }




            static void EvenOrOdd()
            {
                // Write a console application that asks the user for a number.
                // Tell the user if that number is even or odd.

                Console.Clear();
                Console.WriteLine("EVEN OR ODD?\n");

            Console.WriteLine("May I have a number, please?");
            int numberFirst = Convert.ToInt32(Console.ReadLine());
            if (numberFirst % 2 == 0)
                Console.WriteLine("Your number is even!");
            else
                Console.WriteLine("Your number is odd!");


                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }

            static void VowelOrConsonant()
            {
                // Write a console application to check whether a letter is a vowel or consonant.
                // Hint: You can do this problem using a switch or an if condition.

                Console.Clear();
                Console.WriteLine("VOWEL OR CONSONANT?\n");

                Console.WriteLine("Hello! 'Tis I, Kazoo the Alphabet Genie!");
                Console.WriteLine("Give me a letter, and I will magically tell you if it is a vowel or a consonant!");
                string alphaBits = (Console.ReadLine());
            switch (alphaBits)
            {
                case "a":
                    Console.WriteLine("Abracadbra!! You've got a vowel!");
                    break;
                case "b":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
                case "c":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
                case "d":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
                case "e":
                    Console.WriteLine("Abracadbra!! You've got a vowel!");
                    break;
                case "f":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
                case "g":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
                case "h":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
                case "i":
                    Console.WriteLine("Abracadbra!! You've got a vowel!");
                    break;
                case "j":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
                case "k":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
                case "l":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
                case "m":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
                case "n":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
                case "o":
                    Console.WriteLine("Abracadbra!! You've got a vowel!");
                    break;
                case "p":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
                case "q":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
                case "r":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
                case "s":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
                case "t":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
                case "u":
                    Console.WriteLine("Abracadbra!! You've got a vowel!");
                    break;
                case "v":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
                case "w":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
                case "y":
                    Console.WriteLine("My magic is getting stronger!! THIS LETTER IS BOTH!!!");
                    break;
                case "z":
                    Console.WriteLine("Shazam!! That is a consonant!");
                    break;
            }  

                   
                       


                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }

            static void FindLargestNumber()
            {
                // Write a console application that prompts the user to input two integer values.
                // Find and print the greatest value of the two integers.

                Console.Clear();
                Console.WriteLine("FIND THE LARGEST NUMBER\n");

            Console.WriteLine("I'm trying to figure out if I can do math. May I have a number, please?");
            int firstNumeral = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Thank you. May I have another?");
            int secondNumeral = Convert.ToInt32(Console.ReadLine());
                if (firstNumeral > secondNumeral)
                {
                    Console.WriteLine(firstNumeral + " is the bigger number!");
                    
                }
                else
                {
                    Console.WriteLine(secondNumeral + " is the bigger number!");
                    
                }

            Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }

            static void DivisibleBy3()
            {
                // Ask the user for a number and then tell them if it is divisible by 3

                Console.Clear();
                Console.WriteLine("DIVISIBLE BY 3\n");

            Console.WriteLine("Hello1 I'm doing math again - the world is warned! Would you give me a number so that I may determine whether it is divisible by 3?");
            int threeSies = Convert.ToInt32(Console.ReadLine());
            if (threeSies / 3 == 1)
            {
                Console.WriteLine("Divisible by 3. Boy, I'm good!");
            }
            else
            {
                Console.WriteLine("Not divisible by 3. But we're still friends.");
            }
                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }

            static void RestaurantBill()
            {
                // At a restaurant, Mike and his three friends decided to divide the bill evenly.
                // If each person paid $13 then what was the total bill?

                // Returning to the above problem, replace hard-coded values of 4(number of diners)
                // and 13(cost per diner) with values provided by the user.

                // How nice!The restaurant is having Customer Appreciation Week.
                // If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
                // Otherwise, they’ll receive a 5 % discount.

                Console.Clear();
                Console.WriteLine("RESTAURANT BILL\n");

                // Enter your solution here

                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }

            static void AgeCategory()
            {
                // You're responsible for providing a demographic report for your local school district based on age.
                // To do this, you're going to determine which 'category' each person fits into based on their age.
                // The person's age will determine which category they should be in:

                // If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
                // If they're 3 or 4 and should be in preschool print : 'Preschool Maniac'
                // If they're from 5 to 11 and should be in elementary school print : 'Elementary School'
                // From 12 to 14: 'Middle School'
                // From 15 to 18: 'High School'
                // From 19 to 22: 'College'
                // From 23 to 65: 'Working for the Man'
                // From 66 to 100: 'The Golden Years'
                // If the age of the person is less than 0 or more than 100 - it might be an alien
                // print: "This program is for humans".

                Console.Clear();
                Console.WriteLine("AGE CATEGORY\n");

                // Enter your solution here

                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }

            static void WordsToDigits()
            {
                // Having a string representation of a number, you need to print the digit form of the number.
                // Ask the user to enter a string representation of a number from zero to ten.
                // Using switch case, print the digit (0-10) representation of the number.

                Console.Clear();
                Console.WriteLine("WORDS TO DIGITS\n");

                // Enter your solution here

                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }

            static void WhichNameIsLonger()
            {
                // Ask the user for their first and last name.

                // Print the user's full name.
                // If the first name is longer than the last name, print "First is longer."
                // If the first name and last name are the same length, print "Same-sies!"
                // Otherwise, print "Last must be longer!"

                Console.Clear();
                Console.WriteLine("WHICH NAME IS LONGER?\n");

                // Enter your solution here

                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }

            static void AreNamesSame()
            {
                // Ask the user for 2 names.

                // If the two names are the same, print "The names are the same."
                // If they're not the same, print "The names are different."

                Console.Clear();
                Console.WriteLine("ARE THESE NAMES THE SAME?\n");

                // Enter your solution here

                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }

            static void NameAndBirthplace()
            {
                // Ask the user for their first name and where they were born.
                // Print a sentence to the console that repeats this information.

                Console.Clear();
                Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            Console.WriteLine("Hi! What's your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("And where were you born?");
            string birthPlace = Console.ReadLine();
            Console.WriteLine("Your name is " + firstName + " and you're from " + birthPlace + " ! That's so cool!");

                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }

        }
    }
