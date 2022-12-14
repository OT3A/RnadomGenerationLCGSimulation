using System;

namespace RnadomGenerationLCGModels
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SimulationSystem sys = new SimulationSystem();
            Console.WriteLine("Enter the Multiplier : ");
            string Multiplier = Console.ReadLine();
            sys.Multiplier = int.Parse(Multiplier);
            Console.WriteLine("Enter the seed : ");
            string seed = Console.ReadLine();
            sys.Seed = int.Parse(seed);
            Console.WriteLine("Enter the incermental : ");
            string incermental = Console.ReadLine();
            sys.Increment = int.Parse(incermental);

            Console.WriteLine("Enter the models : ");
            string models = Console.ReadLine();
            sys.Modulus = int.Parse(models);

            Console.WriteLine("Enter the numofitration : ");
            string numofitration = Console.ReadLine();
            sys.NumberofIterations = int.Parse(numofitration);


            FillTable.FillSimulationTable(sys);
            for (int i = 0; i < sys.NumberofIterations; i++)
            {
                Console.WriteLine(sys.SimulationTable[i].Random);
            }
            LCGFunction.CalculateCicleLength(sys);
            Console.WriteLine(sys.Cyclelength);



        }
    }
}
