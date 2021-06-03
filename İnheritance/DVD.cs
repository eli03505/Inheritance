using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritance
{
    class DVD : Storage
    {
        public double Speed { get; set; } = 1;
        public double Memory { get; set; } = 10;
        private double free = 10;
        public double GetTime { get; set; }

        public double Media()
        {
            return Memory;
        }
        public override double CopyData(double data)
        {
            if (data > free)
            {
                throw new NoStorage("There is not enough memory", DateTime.Now, 30, "DVD.cs");
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
        public double MemorySecond()
        {
            return Speed;
        }
        public override void Print()
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Memory:{Memory}");
            Console.WriteLine($"Speed:{Speed}");
            Console.WriteLine($"Time:{GetTime}");
            Console.WriteLine($"Free Memory:{FreeMemory()}");
        }
    }
}