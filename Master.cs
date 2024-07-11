using System;
class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");
        Console.WriteLine();
        DisplayMenu();
        }
    static void DisplayMenu()
    {
        while(true)
        {
            Console.WriteLine("Please Enter the following number below from the following menu: ");
            Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year ");
            Console.WriteLine("2. Exit ");
            string option = Console.ReadLine();
            switch(option)
            {
            case "1":
                CalculateRevenue();
                break;
            case "2":
                Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye! ");
                return;
            default:
                Console.WriteLine("Invalid option, please try again. ");
                break;                                   
            }
        }
    }
    static void CalculateRevenue()
    {
        Console.WriteLine("Please enter the number of contestants in previous year: ");
        int previousYear = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number of contestants in current year: ");
        int currentYear = int.Parse(Console.ReadLine());
        int revenue = currentYear * 25;
        bool isRevenueHigher = currentYear > previousYear;

        Console.WriteLine($"Last year's competition had  {previousYear} contestants, and this year's has {currentYear} contestants.");
        Console.WriteLine($"Revenue expected this year is {revenue}." );
        Console.WriteLine($"It is {(isRevenueHigher ? "true" : "false")} that this year's competition is bigger than last year's. ");
        Console.WriteLine();
        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");
        Console.WriteLine();
    }
 }
    


