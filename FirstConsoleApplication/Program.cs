using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select an operation to perform on the 2 numbers: ");
            Console.WriteLine("1. Addition, 2. Subtraction, 3. Multiplication");
            int operation = Convert.ToInt32(Console.ReadLine());

            int result = 0;
            if (operation == 1)
            {
                result = num1 + num2;
                Console.WriteLine("\nThe sum of " + num1 + " and " + num2 + " is: " + result);
            }
            if (operation == 2)
            {
                result = num1 - num2;
                Console.WriteLine("\nThe difference of " + num1 + " and " + num2 + " is: " + result);
            }
            if (operation == 3)
            {
                result = num1 * num2;
                Console.WriteLine("\nThe product of " + num1 + " and " + num2 + " is: " + result);
            }
        }
    }
}
