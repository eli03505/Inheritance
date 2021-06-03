using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritance
{
    abstract class Storage
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public abstract double CopyData(double data);
        public abstract double FreeMemory();
        public abstract void Print();
    }
}