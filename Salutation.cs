using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample
{
    public class Salutation
    {
        private readonly IMessageWriter writer;

        public Salutation(IMessageWriter writer)
        {
            this.writer = writer ?? throw new ArgumentNullException("writer");
        }

        public void Exclaim()
        {
            this.writer.Write("Hello DI");
        }
    }
}
