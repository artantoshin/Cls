using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cls
{
    internal class Class1
    {
        public string name = "Artem";
        public string Name { get { return name; } }
        public Class1(string name)
            {
            this.name = name;
            Console.WriteLine("Hello " + name);
            }
    }
}
