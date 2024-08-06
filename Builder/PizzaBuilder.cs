using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PizzaBuilder
    {
        private bool hasCheese = false;
        private bool hasPepperoni = false;
        private bool hasMushrooms = false;
        private Size size = Size.Round(new SizeF());

        public PizzaBuilder WithCheese()
        {
            hasCheese = true;
            return this;
        }

        public PizzaBuilder WithPepperoni()
        {
            hasPepperoni = true;
            return this;
        }

        public PizzaBuilder WithMushrooms()
        {
            hasMushrooms = true;
            return this;
        }

        public PizzaBuilder OfSize(Size size)
        {
            this.size = size;
            return this;
        }

        public Pizza Build()
        {
            return new Pizza(hasCheese, hasPepperoni, hasMushrooms, size);
        }
    }
}
