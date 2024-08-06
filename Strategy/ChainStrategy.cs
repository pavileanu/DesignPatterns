public abstract class ChainStrategy
{

    private ChainStrategy _next;

    public ChainStrategy Append(ChainStrategy next)
    {
        if (_next == null)
        {
            _next = next;
        }
        else
        {
            _next.Append(next);
        }

        return this;
    }

    public abstract void Do(int n);

    protected void Next(int n) => _next?.Do(n);
}

public class Log : ChainStrategy
{
    public override void Do(int n)
    {
        Console.WriteLine("Logging number:");
        Next(n);
    }
}

public class Transaction : ChainStrategy
{
    public override void Do(int n)
    {
        Console.WriteLine("Starting Transaction");
        Next(n);
        Console.WriteLine("Finishing Transaction");
    }
}

public class Add : ChainStrategy
{
    int _num;
    public Add(int num) => _num = num;

    public override void Do(int n)
    {
        Console.WriteLine($"Adding {_num} to {n}");
        int result = n += _num;
        Console.WriteLine($"Result: {result}");
        Next(result);
    }
}