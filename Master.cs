using System;
class Program
{
    static void Main(string [] args)
    {
        int number, sum=0,n;
        Console.Write("Enter the number of terms: ");
        number = int.Parse(Console.ReadLine());
        n = number;
        for(int i = 1; i < number; i++)
        {
            if(number % i == 0)
            {
                sum = sum + i;
            }
        }
        if (sum == n)
        {
            Console.WriteLine("The number is a perfect number.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("The number is not a perfect number.");
            Console.ReadLine();
        }
    }
}



