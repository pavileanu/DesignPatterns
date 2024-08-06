// Strategy pattern is replacing some logic with something else logic. We have an workflow or an implementaion and we want
// to change a piece (we can use interface).

// Strategy Middleware, here we implemented first, a middleware and strategy changes with every Next Method 
// Strategy Adapter, here we can implement the adapter based on multiple implementations(strategy) - very used
// Strategy Generic, what type we use in generic, there is different implementation

namespace Strategy
{
    public static class StrategyExample
    {
        public static void Main()
        {
            Console.WriteLine("Chain Strategy Start");
            var chain1 = new Log().Append(new Transaction()).Append(new Add(5));
            chain1.Do(10);

            Console.WriteLine();

            var chain2 = new Log().Append(new Add(10)).Append(new Transaction());
            chain2.Do(10);
            Console.WriteLine("Chain Strategy End");

            Console.WriteLine("Adapter Strategy");
            FileController fc1 = new FileController(new LocalFileStorage());
            FileController fc2 = new FileController(new AWSFileStorage());
            Console.WriteLine("Adapter Strategy end");

            Console.WriteLine("Generic Strategy");
            new Thing<A>().Do();
            new Thing<B>().Do();
            Console.WriteLine("Generic Strategy end");
        }
    }
}
