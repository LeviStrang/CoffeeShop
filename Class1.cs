using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enum;

namespace CoffeeShop
{




    public struct employee
    {

        public static double GetHours()
        {


            double hours = Convert.ToDouble(Console.ReadLine());
            return hours;
        }

        public static void CalculatePayroll()
        {
            try
            {
                double hours = 0;
                double hourlyWage = 12.5;
                double total = 0;
                double overtime = 0;
                double overalltotal = 0;
                Console.WriteLine("\nI am going to ask you for all the hours of your five employee.");
                for (int e = 0; e < 5; e++)
                {

                    Console.WriteLine($"\nHow many hours were worked for employee {e + 1}");
                    hours = GetHours();
                    if (hours > 40)
                    {
                        overtime += (hours - 40) * 1.5 * hourlyWage;

                    }
                    else
                    {
                        overtime += 0;

                    }
                    total += hourlyWage * hours;
                }


                overalltotal = total + overtime;


                Console.WriteLine($"The total standard compensation is: {total:c}\nThe total overtime compensation is: {overtime:c}\nThe overall total compensation is {overalltotal:c}");
                Console.ReadLine();
            }
            catch (FormatException fEx)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"An error has occured: {fEx.Message}\n\nPlease try again!");
                Console.ResetColor();
                CalculatePayroll();

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"An error has occured: {ex.Message}\n\nPlease try again!");
                Console.ResetColor();
                CalculatePayroll();
            }
        }
        public static void CalculateSales()
        {
            try
            {
                double totalcost = 0;
                double inputamount = 0;
                double totalSales = 0;

                Console.WriteLine($"To calculate the total sales for today we will need the amount of {coffeeSizes.small}, {coffeeSizes.medium} and {coffeeSizes.large}.\nPlease enter the number of {coffeeSizes.small} coffees sold: ");
                inputamount = Convert.ToDouble(Console.ReadLine());
                totalSales += inputamount;
                totalcost += inputamount * 0.1;

                Console.WriteLine($"\nPerfect! Now enter the number of {coffeeSizes.medium} coffees: ");
                inputamount = Convert.ToDouble(Console.ReadLine());
                totalSales += inputamount * 3;
                totalcost += inputamount * 0.15;

                Console.WriteLine($"\nPerfect! Now enter the number of {coffeeSizes.large} coffees: ");
                inputamount = Convert.ToDouble(Console.ReadLine());
                totalSales += inputamount * 5;
                totalcost += inputamount * 0.20;

                Console.WriteLine($"\n\nThis is great we now have all the coffee sales!\n\nWe now need to get the amount of sandwiches sold.\n\nPlease enter how many {sandwichType.Egg} sandwiches you sold: ");
                inputamount = Convert.ToDouble(Console.ReadLine());
                totalSales += inputamount * 5.5;
                totalcost += inputamount * 0.95;

                Console.WriteLine($"Thats Great! Now enter the amount of {sandwichType.chicken} sandwiches: ");
                inputamount = Convert.ToDouble(Console.ReadLine());
                totalSales += inputamount * 7.5;
                totalcost += inputamount * 1.20;


                double totalprofit = totalSales - totalcost;

                Console.WriteLine($"\n\nThats great! now lets look at your totals. \n\nThe total sales costs today is {totalcost:c} and total sales is {totalSales:c}.\n\nThe total profit for today is {totalprofit:c}!");
            }
            catch (FormatException fEx)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"An error has occured: {fEx.Message}\n\nPlease try again!");
                Console.ResetColor();
                CalculatePayroll();

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"An error has occured: {ex.Message}\n\nPlease try again!");
                Console.ResetColor();
                CalculatePayroll();
            }

        }
    }
}
              
    

