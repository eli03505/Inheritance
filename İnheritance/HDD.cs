using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritance
{
    class HDD : Storage
    {
        public double Speed { get; set; } = 5;
        public double Memory { get; set; } = 20;
        private double free = 25;
        public double GetTime()
        {
            return Memory / Speed;
        }

        public override double CopyData(double data)
        {
            if (data > free)
            {
                throw new NoStorage("We dont have enought memory", DateTime.Now, 32, "HDD.cs");
            }
            else
            {
                free = free - data;
                return data / Speed;
            }
        }
        public override double FreeMemory()
        {
            return free;
        }
        public double MemoryPerSecond()
        {
            return Speed;
        }
        public override void Print()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Memory:{Memory}");
            Console.WriteLine($"Speed:{Speed}");
            Console.WriteLine($"Time:{GetTime()}");
            Console.WriteLine($"Free Memory:{FreeMemory()}");
        }
    }
}