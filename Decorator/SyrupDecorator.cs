using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SyrupDecorator : CoffeeBase
    {
        private ICoffee coffee;
        protected int syrupQuantity;

        public SyrupDecorator(ICoffee coffee)
        {
            this.coffee = coffee;
            description = coffee.GetDescription() + ", with Syrup";
            price += 0.3m;
        }

        public override string GetDescription()
        {
            return description;
        }

        public override decimal GetPrice()
        {
            return price;
        }

        public virtual int GetSyrupQuantity()
        {
            return syrupQuantity;
        }
    }
}
