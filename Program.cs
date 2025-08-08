using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTablePrinter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            while (true)
            {
                Console.Write("Enter an integer (1-10): ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out number) || number < 1 || number > 10)
                {
                    Console.WriteLine("Invalid input. Please enter an integer between 1 and 10.");
                    continue;
                }
                break;
            }
            Console.WriteLine($"\nMultiplication Table for {number}:");
            Console.WriteLine("--------------------------");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
    }
}
