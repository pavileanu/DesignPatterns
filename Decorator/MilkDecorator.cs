using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class MilkDecorator : CoffeeBase
    {
        private ICoffee coffee;

        public MilkDecorator(ICoffee coffee)
        {
            this.coffee = coffee;
            description = coffee.GetDescription() + ", with Milk";
            price += 0.5m;
        }

        public override string GetDescription()
        {
            return description;
        }

        public override decimal GetPrice()
        {
            return price;
        }

    }
}
