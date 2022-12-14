using System;
using System.Collections.Generic;
using System.Text;

namespace RnadomGenerationLCGModels
{
   public class SimulationSystem
    {
        public SimulationSystem()
        {
            SimulationTable = new List<SimulationCase>();
        }
        ///////////// INPUTS /////////////
        public int Seed { get; set; }
        public int Multiplier { get; set; }
        public int Increment { get; set; }
        public int Modulus { get; set; }
        public int NumberofIterations { get; set; }
        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public int Cyclelength { get; set; }
    }
}
