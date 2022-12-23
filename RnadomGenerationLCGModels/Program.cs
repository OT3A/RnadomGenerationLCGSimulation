using System;

namespace RnadomGenerationLCGModels
{
    public class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //    SimulationSystem sys = new SimulationSystem();
        //    Console.WriteLine("Enter the Multiplier : ");
        //    string Multiplier = Console.ReadLine();
        //    sys.Multiplier = int.Parse(Multiplier);
        //    Console.WriteLine("Enter the seed : ");
        //    string seed = Console.ReadLine();
        //    sys.Seed = int.Parse(seed);
        //    Console.WriteLine("Enter the incermental : ");
        //    string incermental = Console.ReadLine();
        //    sys.Increment = int.Parse(incermental);

        //    Console.WriteLine("Enter the models : ");
        //    string models = Console.ReadLine();
        //    sys.Modulus = int.Parse(models);

        //    Console.WriteLine("Enter the numofitration : ");
        //    string numofitration = Console.ReadLine();
        //    sys.NumberofIterations = int.Parse(numofitration);


        //    FillTable.FillSimulationTable(sys);
        //    for (int i = 0; i < sys.NumberofIterations; i++)
        //    {
        //        Console.WriteLine(sys.SimulationTable[i].Random);
        //    }
        //    LCGFunction.CalculateCicleLength(sys);
        //    Console.WriteLine(sys.Cyclelength);



        //}


        // Recursive function to
        // return gcd of a and b
        static int __gcd(int a, int b)
        {
            // Everything divides 0
            if (a == 0 || b == 0)
                return 0;

            // base case
            if (a == b)
                return a;

            // a is greater
            if (a > b)
                return __gcd(a - b, b);

            return __gcd(a, b - a);
        }

        // function to check and print if
        // two numbers are co-prime or not
        static void coprime(int a, int b)
        {

            if (__gcd(a, b) == 1)
                Console.WriteLine("Co-Prime");
            else
                Console.WriteLine("Not Co-Prime");
        }
        public static bool isprime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }

        // Driver code
        public static void Main()
        {
           if(isprime(13))
            {
                Console.WriteLine("Co-Prime");

            }
           else
                Console.WriteLine("Nooooooooo");

            double temp = Math.Pow(2, 12);
            Console.WriteLine(temp);
            if((temp % 13 == 0))
                Console.WriteLine("yeeeees");




        }
    }
}

