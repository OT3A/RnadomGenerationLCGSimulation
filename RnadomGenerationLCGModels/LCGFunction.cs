using System;
using System.Collections.Generic;
using System.Text;

namespace RnadomGenerationLCGModels
{
    class LCGFunction
    {
        public static int GenerateRandom(int Seed, int Modulus, int Multiplier, int Increment)
        {
            return ((Seed * Multiplier) + Increment) % Modulus; ;
        }
        public static void  CalculateCicleLength(int first , int next , ref int  count ,ref bool check)
        {
            if (first != next) 
                 count++;            
            else
                check = false;
                        
           
        }
        public static void CalculateCicleLength(SimulationSystem sys)
        {
            int count = 1;
            bool cheack = true;
            int first = sys.SimulationTable[0].Random;
            for (int i = 1; i < sys.SimulationTable.Count; i++)
            {
                if (first != sys.SimulationTable[i].Random)
                {
                    count++;
                }
                else
                {
                    cheack = false;
                    break;
                }
            }
            if(!cheack)
                sys.Cyclelength = count;
            else
                sys.Cyclelength = -1;


        }
    }
}
