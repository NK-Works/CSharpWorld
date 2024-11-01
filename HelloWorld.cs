using System;

namespace Basic
{
    class Program
    {
        static void Main(string[] args) //static is basically the value which is saved only once and is used by everyone and in it the most recent change is saved 
        {
            string name = "Neverknow";
            int a = 4760 , b = 10000;

            Console.WriteLine("Hello {0}. Your ID is: {1}. Your salary is: {2}", name, a, b); //console aka terminal is the class of system

            Console.WriteLine("Enter new values...");

            Console.Write("Enter name: ");
            name = Console.ReadLine(); //string doesn't have a predefined size

            Console.Write("Enter your ID: ");
            a = Convert.ToInt32(Console.ReadLine());
            // a = sizeof(int);
            // Console.WriteLine(a);  This directly changes the value given to a using the value of the size of 'a'
            Console.WriteLine("The size of the data type is: " + sizeof(int));
            
            Console.Write("Enter salary: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello {0}. Your ID is: {1}. Your salary is: {2}", name, a, b);
        }
    }
}
