using System;
class Program
{
    static void Main()
    {
        String string1 = " Platea dictumst quisque sagittis purus sit amet volutpat consequat mauris.";
        int count = 0;
        for(int i = 0; i < string1.Length;i++){
            if(string1[i] !=' ') count++;
        }
        if (count > 140)
        Console.WriteLine("Rejected");
        else
        Console.WriteLine("Posted");
    }
    }
       



