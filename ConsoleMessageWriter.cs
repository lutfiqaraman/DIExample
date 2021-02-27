using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
