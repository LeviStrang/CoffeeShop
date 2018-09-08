using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop;
using Enum;

namespace CoffeeHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please select from the choices:\nPress 1 to {Menu.CalculateSales} for today.\nPress 2 to view {Menu.PayRoll} information.\nPress 3 to exit.");
           
            ConsoleKey readKey = Console.ReadKey().Key;
            if (readKey == ConsoleKey.D1 || readKey == ConsoleKey.NumPad1)
            {
                employee.CalculateSales();
            }
            else if (readKey == ConsoleKey.D2 || readKey == ConsoleKey.NumPad2)
            {
                employee.CalculatePayroll();
            }
            else if (readKey == ConsoleKey.D3 || readKey == ConsoleKey.NumPad3)
            {
                Console.Clear();
                System.Environment.Exit(0);
                
            }
            else
            {
                Console.WriteLine("Please try again!");
                Console.ReadLine();
            }

        }

    }
}


