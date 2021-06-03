using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage storage1 = new HDD()
            {
                Name = "Hdd",
                Model = "Toshiba"
            };

            storage1.Print();
            try
            {
                Console.WriteLine(storage1.CopyData(3));
            }
            catch (NoStorage ex)
            {
                ex.Show();
            }
            storage1.Print();


            Storage storage3 = new DVD
            {
                Name = "DVD",
                Model = "Pioneer"
            };

            storage3.Print();
            try
            {
                Console.WriteLine(storage3.CopyData(2));
            }
            catch (NoStorage ex)
            {
                ex.Show();
            }
            storage3.Print();
        }
    }
}