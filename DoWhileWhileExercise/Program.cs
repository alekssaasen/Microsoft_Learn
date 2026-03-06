using System.Globalization;

namespace ThreeCodingChallenges;

class Program
{
    static void Main(string[] args)
    {
       // Challenge 1 - Validate integer input

       string? input;
       Console.WriteLine("Enter a number between 5 and 10.\n");

       while (true)
       {
           input = Console.ReadLine();
           int num = 0;
           bool validNumber = int.TryParse(input, out num);

           if (!validNumber)
           {
               Console.WriteLine("Please enter a number.");
               continue;
           }

           if (num < 5)
           {
               Console.WriteLine("The number needs to be above or equal to 5.");
           }
           else if (num > 10)
           {
               Console.WriteLine("The number needs to be bellow or equal to 10.");
           }
           else
           {
               Console.WriteLine($"You entered: {input}");
               break;
           }
       }
    }
}