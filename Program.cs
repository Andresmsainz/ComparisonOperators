using System;

namespace ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comparison Operators!");
            int x = 0;
            int y = 0;

            Console.WriteLine("Enter No. 1");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter No. 2");
            y = int.Parse(Console.ReadLine());

            if (x == y)
                Console.WriteLine(x + " is equal to " + y);
            else
                Console.WriteLine(x + " is not equal to " + y);
            if (x > y)
                Console.WriteLine(x + " is greater than " + y);
            else if (x < y)
                Console.WriteLine(x + " is less than " + y);
        }
    }
}
