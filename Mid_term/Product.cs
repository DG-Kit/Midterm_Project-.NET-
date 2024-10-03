using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_term
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; } // This will represent the quantity added to the order

        // Override ToString() for proper display in ListBox
        public override string ToString()
        {
            return $"{Name} - ${Price:F2}"; // Customize how you want it displayed
        }
    }
}
