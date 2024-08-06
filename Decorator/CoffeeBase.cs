using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{    public class CoffeeBase : ICoffee
    {
        protected string description = "Base Coffee";
        protected decimal price = 1.0m;

        public virtual string GetDescription()
        {
            return description;
        }

        public virtual decimal GetPrice()
        {
            return price;
        }
        // Optional: Reference to a decorated object for chaining
        //protected ICoffee DecoratedCoffee { get; set; }
    }
}
