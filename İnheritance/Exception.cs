using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iheritance
{
    class NoStorage : ArgumentException
    {
        public NoStorage(string txt, DateTime timeException, int errorLine, string source)
        {
            Text = txt;
            TimeException = timeException;
            ErrorLine = errorLine;
            Source = source;
        }
        public string Text { get; set; }
        public DateTime TimeException { get; set; }
        public int ErrorLine { get; set; }
        public string Source { get; set; }

        public void Show()
        {
            Console.WriteLine($"Text{Text}");
            Console.WriteLine($"TimeException{TimeException}");
            Console.WriteLine($"Error Line:{ErrorLine}");
            Console.WriteLine($"Source{Source}");
        }
    }
}