using System;
namespace SwitchStatement
{
    class SwitchStatement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number (as an integer): ");
            // Using try-catch method to detect if a character is introduced in place of integer
            try
            {
                int number = Convert.ToInt32(Console.ReadLine()); // Taking the input number
                
                // Writing the different cases for the numbers enter from 1 to 9
                switch (number) 
                {
                    case 1: Console.WriteLine("One"); break;

                    case 2: Console.WriteLine("Two"); break;

                    case 3: Console.WriteLine("Three"); break;

                    case 4: Console.WriteLine("Four"); break;

                    case 5: Console.WriteLine("Five"); break;

                    case 6: Console.WriteLine("Six"); break;

                    case 7: Console.WriteLine("Seven"); break;

                    case 8: Console.WriteLine("Eight"); break;

                    case 9: Console.WriteLine("Nine"); break;

                    // If the numbers between 1 and 9 are not entered then show this
                    default: Console.WriteLine("Error: you must enter an integer 1 and 9"); break;
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Error: you must enter an integer.");
            }
            Console.ReadLine();
        }
    }
}