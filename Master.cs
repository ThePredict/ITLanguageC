using System;
class Program {
  public static void Main ()
  {
   const double Base_Rate = 200;
       const double Hour_Rate = 150;
       const double Mile_Rate = 2;
        double inputMiles = 3000;
        double inputHours = 103;
        double total = 0;
    total = Base_Rate + (inputMiles * Mile_Rate) + (inputHours * Hour_Rate);
    Console.WriteLine("{0} + {1} * {2} + {3} * {4}", Base_Rate, Hour_Rate, inputMiles, Mile_Rate, inputHours);
    Console.WriteLine("The total is {0}", total);
  }
}
    
    

   