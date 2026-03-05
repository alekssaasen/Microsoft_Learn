namespace Loops;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i ++)
        {
            Console.WriteLine(i);
            if (i == 7) break;
        }
        /*
         For loop
         string[] names = { "Alex", "Eddie", "David", "Michael" };
        for (int i = names.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(names[i]);
        }
         */
        
        // Foreach loop
        /*
        string[] names = { "Alex", "Eddie", "David", "Michael" };
        foreach (string name in names)
        {
            // Can't do this:
            if (name == "David") name = "Sammy";
        }
        */
        string[] names = { "Alex", "Eddie", "David", "Michael" };
        for (int i = 0; i < names.Length; i++)
            if (names[i] == "David") names[i] = "Sammy";

        foreach (var name in names) Console.WriteLine(name);
    }
}