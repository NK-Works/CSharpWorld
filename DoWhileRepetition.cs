using System;
namespace DoWhileRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double average;
            
            // Asking for the upperbound number
            Console.Write("Please enter the upperbound number (as a integer): ");
            int upperbound = Convert.ToInt32(Console.ReadLine());
            
            // Declaring and initialising the current iteration number
            int number = 1;

            // Using the loop to do the calculation
            do
            {
                sum += number;
                number++;
                Console.WriteLine("Current number: " + number + " the sum is " + sum);
            }while (number <= upperbound);

            // Printing the sum
            Console.WriteLine("The sum is " + sum);
            
            // Printing the average
            average = (double)sum/upperbound;
            Console.WriteLine("The average is " + average);
            
            Console.ReadLine();
        }
    }
}