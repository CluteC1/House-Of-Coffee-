using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseOfCoffee1
{
    public struct Coffee
    {
        private enum coffee : byte { small = 1, medium = 3, large = 5 } // I used this enum in string interpolation 
        private enum sandwiches : byte { eggsandwich, chickenbiscuit }
        private enum sizesofCoffee : byte { small, medium, large }

         static void Employee() // this will take all employees information
         {
            try
            {
                double overtime = 0.00;
                double totalpay = 0.00;

                for (var i = 0; i < 5; i++)
                {
                    Console.Write("Enter the number of hours each employee worked: ");
                    double hours = Convert.ToInt32(Console.ReadLine());

                    if (hours > 40)
                    {
                        overtime += (12.50 * 1.5) * (hours - 40);
                        totalpay += 40 * 12.50;
                    }
                    else if (hours <= 40)
                    {
                        totalpay += hours * 12.50;
                    }


                }

                Console.WriteLine($"The total overtime pay is ${overtime}");
                Console.WriteLine($"The total hourly pay is ${totalpay}\n");
                Console.WriteLine("If you would like to go to the Main Menu enter 1. ");
                Console.WriteLine("If you would like to exit enter 2 ");
                int input = Convert.ToInt32(Console.ReadLine());

                if(input == 1)
                {
                    Console.Clear();
                    MainMenu();
                }
                else if (input == 2)
                {
                    Environment.Exit(0);
                }

            } catch (Exception)
            {
                Console.WriteLine("You input was invalid. Please use number keys.");
                Console.WriteLine("Press enter to retry.");
                Console.WriteLine("If you would like to exit enter 2");
                int input = Convert.ToInt32(Console.ReadLine());
                if(input == 2)
                {
                    Environment.Exit(0);
                }
                Console.Clear();
                Employee();
                
            }
         }
        public static void TotalSales()// this method is going to find the coffee shop's total sales for the day
        {
            try
            {
                double totalSmallCups = 0;
                double totalMediumCups = 0;
                double totalLargeCups = 0;
                double eggSandwhichsold = 0;
                double chickBiscuitsold = 0;
                coffee small = coffee.small;
                coffee medium = coffee.medium;
                coffee large = coffee.large;
                Console.WriteLine("Hello, This program will give you the total sales for today. Press enter to continue.\n");
                Console.Clear();
                Console.Write($"Please enter how many {small} coffees sold: ");
                totalSmallCups = Convert.ToDouble(Console.ReadLine());

                Console.Write($"Please enter how many {medium} cups of coffee sold: ");
                totalMediumCups = Convert.ToDouble(Console.ReadLine());

                Console.Write($"Please enter how many {large} cups of coffee sold: ");
                totalLargeCups = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter how many egg sandwich's were sold: ");
                eggSandwhichsold = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter how many chicken biscuits were sold: ");
                chickBiscuitsold = Convert.ToDouble(Console.ReadLine());

                double totalSales = totalSmallCups * (int)small + totalMediumCups * (int)medium + totalLargeCups * (int)large + eggSandwhichsold * 5.50 + chickBiscuitsold * 7.50;
                Console.Write($"Your total sales for today are: ${totalSales}\n");

                double totalCost = totalSmallCups * .10 + totalMediumCups * .15 + totalLargeCups * .20 + eggSandwhichsold * .95 + chickBiscuitsold * 1.20;
                Console.Write($"Your total cost for today are: ${totalCost}\n");

                double totalProfit = totalSales - totalCost;
                Console.Write($"Your total profit is: ${totalProfit}\n");

                Console.WriteLine("Would you like to add anything else today? Type 1 for yes. Type 2 for Main Menu!");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    TotalSales();
                }
                else if (input == 2)
                {
                    Console.Clear();
                    MainMenu();
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Your input was invalid. Please select only number keys.");
                Console.WriteLine("If you would like to retry please press enter.");
                Console.ReadLine();
                Console.Clear();
                TotalSales();
            }
        }
        public static void MainMenu() // This method will be used to allow the user to select what they want
        {
            try
            {


                Console.WriteLine("What would you like to do today?\n");
                Console.WriteLine("Enter 1 to find out the payroll and to find overtime pay.\n");
                Console.WriteLine("Enter 2 to calculate todays total sales, cost of goods, and profit.\n");
                Console.WriteLine("Enter 3 to exit the program.");

                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Employee();
                        break;
                    case 2:
                        Console.Clear();
                        TotalSales();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            } catch(Exception)
            {
                Console.WriteLine("Your input was invalid. Please select only numbers.");
                Console.WriteLine("Press enter to retry.");
                Console.ReadLine();
                Console.Clear();
                MainMenu();
            }
               

        }

        
    }
}
