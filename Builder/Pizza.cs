using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Pizza
    {
        public bool HasCheese { get; set; }
        public bool HasPepperoni { get; set; }
        public bool HasMushrooms { get; set; }
        public Size Size { get; set; }

        public Pizza(bool hasCheese, bool hasPepperoni, bool hasMushrooms, Size size)
        {
            HasCheese = hasCheese;
            HasPepperoni = hasPepperoni;
            HasMushrooms = hasMushrooms;
            Size = size;
        }
    }
}
