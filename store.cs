using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication
{
    public class Store
    {
        public string Name { get; set; } = "generic store";
        public string Description { get; set; } = "generic description";

        public List<Item> Items { get; set; } = new List<Item>();

        public void Greeting()
        {
            Console.WriteLine($"Welcome to {Name}, {Description}");
        }
    }
}
