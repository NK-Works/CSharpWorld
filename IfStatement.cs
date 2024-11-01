using System;
namespace IfStatement
{
    class IfStatement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number (as an integer): ");
            // Using try-catch method to detect if a character is introduced as input as input in place of integer
            try
            {
                int number = Convert.ToInt32(Console.ReadLine()); // Taking the input number

                // Specifying the conditions for the numbers from 1 to 9
                if (number == 1)
                {
                    Console.WriteLine("ONE");
                }
                else if (number == 2)
                {
                    Console.WriteLine("TWO");
                }
                else if (number == 3)
                {
                    Console.WriteLine("THREE");
                }
                else if (number == 4)
                {
                    Console.WriteLine("FOUR");
                }
                else if (number == 5)
                {
                    Console.WriteLine("FIVE");
                }
                else if (number == 6)
                {
                    Console.WriteLine("SIX");
                }
                else if (number == 7)
                {
                    Console.WriteLine("SEVEN");
                }
                else if (number == 8)
                {
                    Console.WriteLine("EIGHT");
                }
                else if (number == 9)
                {
                    Console.WriteLine("NINE");
                }
                
                // If the numbers betwen 1 and 9 are not entered then show this
                else
                {
                    Console.WriteLine("ERROR: you must enter an integer 1 and 9");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("ERROR: you must enter a number.");
            }
            Console.ReadLine();
        }
    }
}
