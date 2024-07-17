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
                Competition();
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
    static void Competition()
    {
        Console.WriteLine("Please enter the number of contestants in previous year: ");
        int previousYear = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number of contestants in current year: ");
        int currentYear = Int32.Parse(Console.ReadLine());
        if(currentYear > previousYear * 2)
        Console.WriteLine("The competition is bigger than ever!");
        else
        if (currentYear > previousYear && currentYear <= (previousYear * 2))
        Console.WriteLine("The competition is more than twice as big this year!");
        else 
        if (currentYear < previousYear)
        Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        else
        Console.WriteLine("Please enter a valid number");
        Console.WriteLine();
        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");
        Console.WriteLine();
    }
 }
    


