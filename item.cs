using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }

        public void Label()
        {
            Console.WriteLine($"{Name} - {Description} - {Price}");
        }
    }
}
