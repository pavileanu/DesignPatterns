// Decorator is a pattern where at runtime we decide some logic that would apply to an object.

// Implement this way, 1) Make a class of what we need, IMPLEMENT AN INTERFACE FOR THE CLASS IWHATWENEED.
// 2) Create a decorator class, in constructor receive the base class object, save the base class in a field reference for usage in methods.
// 3) Decorator class needs to inherit from base class for chaining purpose.
// 4) HOW TO USE, create an interface object for the base class, apply decorators to the object creating decorator instances. In the end
// we would have a fully customise object using decorators.

// OTHER OPTIONS, 1) Create a method DecorateMethod(things to change) -- bad aproach, doesn't have single responsabilities.
// 2) Create a static class with static methods to decorate the object, this is better, but still has scalability issues and can 
// become big


// Create a base coffee
namespace Decorator
{

    public static class DecoratorExample
    {
        public static void Main()
        {
            ICoffee coffee = new CoffeeBase();

            // Add Milk decorator
            coffee = new MilkDecorator(coffee);

            // Add Syrup decorator (decorating the MilkDecorator)
            coffee = new SyrupDecorator(coffee);

            Console.WriteLine(coffee.GetDescription());
            Console.WriteLine(coffee.GetPrice());

            /* Don t do this, it is for interaface changing with is
            if (coffee is IMilkCoffee milkCoffee)
            {
                int milkQuantity = milkCoffee.GetMilkQuantity();
                Console.WriteLine($"Coffee with milk: {milkQuantity} unit(s)");
            }*/
        }
    }

}