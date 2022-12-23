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
        public static void CalculateCicleLengthAlgo(SimulationSystem sys)
        {
            int C = sys.Increment;
            int M = sys.Modulus;
            int a = sys.Multiplier;
            int k = M - 1;
            double temp = Math.Pow(a, k)-1;
            if(C!=0 && RelativePrime(C,M) && a == 4*(M-1)+1 && isPowerOfTwo(M)  )
            {
                sys.Cyclelength = M;
            }

            else if (C == 0 && isPowerOfTwo(M) && isOdd(sys.Seed)&&((a == 5 +8 * k) ||(a == 3 + 8*k) ))
            {
                sys.Cyclelength = M / 4;
            }
            else if(C == 0 && isprime(M) && (temp % M ==0) )
            {
                sys.Cyclelength =  M - 1;
            }
            else
            {
                CalculateCicleLength(sys);

            }
        }


        static int GetCommonD(int a, int b)
        {
            // Everything divides 0
            if (a == 0 || b == 0)
                return 0;

            // base case
            if (a == b)
                return a;

            // a is greater
            if (a > b)
                return GetCommonD(a - b, b);

            return GetCommonD(a, b - a);
        }

        // function to check and print if
        // two numbers are co-prime or not
        static bool RelativePrime(int a, int b)
        {

            if (GetCommonD(a, b) == 1)
                return true;
            else
                return false;
        }

        static bool isPowerOfTwo(int n)
        {
            return (int)(Math.Ceiling((Math.Log(n) / Math.Log(2))))
                  == (int)(Math.Floor(((Math.Log(n) / Math.Log(2)))));
        }
        static bool isOdd(int n)
        {
            if (n % 2 == 0)
                return false;
            else
                return true;
        }
        public static bool isprime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }


    }
}
