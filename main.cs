using System;

class Program {
    public static void Main(string[] args) {
      var fullName = ConcatName("Dario", "D Giavazzi");
        Console.WriteLine("Hello World! " + fullName + " is Here");
      }

    private static string ConcatName(string firstName, string lastName) {
        return firstName + " " + lastName;
    }
}  