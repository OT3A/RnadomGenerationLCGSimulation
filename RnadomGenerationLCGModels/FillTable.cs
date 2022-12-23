using System;
using System.Collections.Generic;
using System.Text;

namespace RnadomGenerationLCGModels
{
   public class FillTable
    {
        public static void FillSimulationTable(SimulationSystem sys )
        {
            int next = 0;
            int count = 1;
            int first =0 ;
            bool check = true;
            for (int i = 0; i< sys.NumberofIterations;i++)
            {
                SimulationCase row = new SimulationCase();
                row.Index = i + 1;
                if(i == 0)
                {
                    row.Random = LCGFunction.GenerateRandom(sys.Seed, sys.Modulus, sys.Multiplier, sys.Increment);
                    next = row.Random;
                    first = next;
                }
                else
                {
                    row.Random = LCGFunction.GenerateRandom(next, sys.Modulus, sys.Multiplier, sys.Increment);
                    next = row.Random;
                    if(check)
                    {
                        // First Algorithm To Calculate Cicle Length
                       //  LCGFunction.CalculateCicleLength(first, next,ref count ,ref check);

                    }
                }
                sys.SimulationTable.Add(row);

            }
            if(check)
            {
                count = -1;
            }
               sys.Cyclelength = count;

             // Secound Algorithm To Calculate Cicle Length
                LCGFunction.CalculateCicleLengthAlgo(sys); 

        }

    }
}
