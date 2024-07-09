using System;
class Program
{
    static void Main(string [] args)
    {
       int Countd = 0;
        int Counte = 0;
        int Countf = 0;
        double Sumd = 0;
        double Sume = 0;
        double Sumf = 0;

        char salesperson = 'n';
        Console.WriteLine("Enter the salesperson initials or 'z' to quit");
        while (salesperson != 'Z')
        {
            Console.Write("Who? (F,E,D) :");
            salesperson = char.ToUpper(Console.ReadLine()[0]);

            switch (salesperson)
            {
            case 'D':
                Console.Write("(Danielle) Enter the sales amount: ");
                Sumd += double.Parse(Console.ReadLine());
                Countd++;
                break;
            case 'E':
                Console.Write("(Edward) Enter the sales amount: ");
                Sume += double.Parse(Console.ReadLine());
                Counte++;
                break;
            case 'F':
                Console.Write("(Francis) Enter the sales amount: ");
                Sumf += double.Parse(Console.ReadLine());
                Countf++;
                break;
            case 'z':
                break;
            default:
                Console.WriteLine("Intermediate output: Error, invalid salesperson selected, please try again");
                break;
            }
        }
        Console.WriteLine("Danielle's sales total is {0}", Sumd);
        Console.WriteLine("Edward's sales total is {0}", Sume);
        Console.WriteLine("Francis's sales total is {0}", Sumf);
        Console.WriteLine("Grand total of all sales is {0}", Sumd + Sume + Sumf);
        if (Sumd > Sume)
        {
            if (Sumd > Sumf)
                Console.WriteLine("Danielle has the highest sales");
            else
                Console.WriteLine("Francis has the highest sales");
        }
        else if (Sume > Sumf)
            Console.WriteLine("Edward has the highest sales");
    }
}



