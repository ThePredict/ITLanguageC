using System;
class Program
{
    static void Main(string [] args)
    {
        int windspeed = (int)175.99;
        if(windspeed >= 157)
        {
            Console.WriteLine("Category 5");
        }
        else if (windspeed >= 130)
        {
            Console.WriteLine("Category 4");
        }
        else if (windspeed >= 111)
        {
            Console.WriteLine("Category 3");
        }
        else if (windspeed >= 96)
        {
            Console.WriteLine("Category 2");
        }
        else if (windspeed >= 74)
        {
            Console.WriteLine("Category 1");
        }
        else
        {
            Console.WriteLine("Not a hurricane");
        }
    }
}



