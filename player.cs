using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication
{
    class player
    {
        public string Name { get; set; }

        public void Greeting()
        {
            Console.WriteLine($"Hello {Name}");
        }
    }
}
