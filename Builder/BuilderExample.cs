// If having a lot of properties to create an object, we need to have multiple constructors and hard to maintain
// Another is C# web host where we add a lot of services
// Solution, we createa a builder class with properties for each method and with BUILD METHOD CREATE THE INTENDED OBJECT (WEB SERVER, PIZZA)

using Builder;
using System.Drawing;

public static class BuilderExample
{ 
    public static void Main()
    {
        Pizza largeCheesePizza = new PizzaBuilder()
          .WithCheese()
          .OfSize(new Size(1, 1))
          .Build();

        Console.WriteLine(largeCheesePizza.ToString());
    }

}