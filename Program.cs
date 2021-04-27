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

            Console.WriteLine("Logical Operators!");

            bool bHasLicence = false;
            bool bKnowsHowToDrive = false;
            string sResponse = "";

            //Input
            Console.WriteLine("Did you learn how to drive?");
            sResponse = Console.ReadLine();

            if (sResponse.ToLower() == "yes")
            {
                bKnowsHowToDrive = true;
            }
            else
            {
                bKnowsHowToDrive = false;
            }

            Console.WriteLine("Did you get your licence?");
            sResponse = Console.ReadLine();

            if (sResponse.ToLower() == "yes")
            {
                bHasLicence = true;
            }
            else
            {
                bHasLicence = false;
            }

            // Logic
            if (bHasLicence == true && bKnowsHowToDrive == true)
            {
                Console.WriteLine("You are good to go");
            }
            else
            {
                if (bHasLicence == false && bKnowsHowToDrive == false)
                {
                    Console.WriteLine("You need to learn how to drive and get a licence");
                }
                else if (bKnowsHowToDrive == false)
                {
                    Console.WriteLine("You still need to learn how to drive");
                }
                else if (bHasLicence == false)
                {
                    Console.WriteLine("You still need to get your licence");
                }
                Console.WriteLine("The stars... not today");
            }

            bool bTookShower = false;
            bool bWentForSwim = false;

            //Input
            Console.WriteLine("Did you take a shower?");
            sResponse = Console.ReadLine();

            if (sResponse.ToLower() == "yes")
            {
                bTookShower = true;
            }
            else
            {
                bTookShower = false;
            }

            Console.WriteLine("Did you go for a swim?");
            sResponse = Console.ReadLine();

            if (sResponse.ToLower() == "yes")
            {
                bWentForSwim = true;
            }
            else
            {
                bWentForSwim = false;
            }

            if (bWentForSwim || bTookShower)
            {
                Console.WriteLine("You are wet...");
            }
            else
            {
                Console.WriteLine("You are dry...");
            }
        }
    }
}
