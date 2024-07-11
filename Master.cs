using System;
class Program
{
    static void Main(string [] args)
    {
       double sum = 0;
        bool up = true;
        bool down = true;
        bool correct_temperature;
        double temperature_range;
        double[] temperature = new double[5];
            for(int i = 0; i < 5; i++)
        {
            do
            {
                Console.Write("INPUT Temperature : ");
                correct_temperature = double.TryParse(Console.ReadLine(), out temperature_range);
                if (!correct_temperature || temperature_range < -30 || temperature_range > 130)
                {
                    Console.WriteLine("EXCEPTION Temperature " + (temperature_range) + " is invalid, Please enter a valid temperature between -30 and 130");
                }
            }
            while(!correct_temperature || temperature_range < -30 || temperature_range > 130);
            temperature[i] = temperature_range;
        }
        for(int i = 1; i < temperature.Length; i++)
        {
            if(temperature[i] < temperature [i-1])
            {
                up = false;
            }
            else if (temperature[i] > temperature [i-1])
            {
                down = false;
            }
        }
        if(up)
        {
            Console.WriteLine("Getting warmer");
        }
        else if (down)
        {
            Console.WriteLine("Getting cooler");
        }
        else
        {
            Console.WriteLine("It's a mixed bag");
        }
        Console.Write("OUTPUT 5-day Temperature [");
        for(int i = 0; i < temperature.Length; i++)
        {
            Console.Write(temperature[i]);
            if(i < temperature.Length - 1)
            {
                Console.Write(",");
            }   
        }
        Console.WriteLine("]");
        foreach(double temp in temperature)
        {
            sum += temp;
        }
        double avgTemperature = sum / temperature.Length;
        Console.WriteLine("OUTPUT Average Temperature is " + (avgTemperature) + " degrees");
    }
}



