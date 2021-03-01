using System;

namespace Processor
{
    class Program
    {
        static void Main(string[] args)
        {
            CPU.s_CPU_Desc desc = new CPU.s_CPU_Desc();

            paramInput("Frequency", ref desc.Freq);
            paramInput("Physical cores count", ref desc.Phy_Cores);
            paramInput("Logical cores count", ref desc.Log_Cores);
            paramInput("Manufacturer", ref desc.Manufacturer);
            paramInput("Socket", ref desc.Socket);
            paramInput("L1Chache", ref desc.L1Chache);
            paramInput("L2Chache", ref desc.L2Chache);
            paramInput("L3Chache", ref desc.L3Chache);

            CPU device = new CPU(desc);
            Console.WriteLine(device.ToString());
            Console.ReadKey();
        }
        static void paramInput(string paramName, ref int variable)
        {
            Console.Write("Enter CPU param - " + paramName + ":");
            try
            {
                variable = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error during string convertation to INT32. Try again.");
                paramInput(paramName, ref variable);
            }
        }
        static void paramInput(string paramName, ref string variable)
        {
            Console.Write("Enter CPU param - " + paramName + ":");
            variable = Console.ReadLine();
        }
    }

    class CPU
    {
        public struct s_CPU_Desc
        {
            public int Freq;
            public int Phy_Cores;
            public int Log_Cores;
            public string Manufacturer;
            public string Socket;
            public int L1Chache;
            public int L2Chache;
            public int L3Chache;
        }

        public CPU(s_CPU_Desc deviceDesc)
        {
            this.description = deviceDesc;
        }
        private int SomeCalculation_BUT_NOT_REALLY()
        {
            return description.Freq * description.Phy_Cores;
        }
        public override string ToString()
        {
            string output = string.Empty;

            output += "CPU Frequency    - " + Convert.ToString(description.Freq) + '\n';
            output += "CPU Phy_Cores    - " + Convert.ToString(description.Phy_Cores) + '\n';
            output += "CPU Log_Cores    - " + Convert.ToString(description.Log_Cores) + '\n';
            output += "CPU Manufacturer - " + Convert.ToString(description.Manufacturer) + '\n';
            output += "CPU Socket       - " + Convert.ToString(description.Socket) + '\n';
            output += "CPU L1Chache     - " + Convert.ToString(description.L1Chache) + '\n';
            output += "CPU L2Chache     - " + Convert.ToString(description.L2Chache) + '\n';
            output += "CPU L3Chache     - " + Convert.ToString(description.L3Chache) + '\n';
            output += "CPU Multi core operations count - " + Convert.ToString(SomeCalculation_BUT_NOT_REALLY()) + '\n';

            return output;
        }

        public s_CPU_Desc description { get; private set; }
    }
}
