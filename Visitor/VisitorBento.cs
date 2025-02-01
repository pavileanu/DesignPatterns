public interface ICreate
{
    public void Create(Processor p);
}

public abstract class Base : ICreate
{
    public string Name { get; set; }

    public abstract void Create(Processor p);
}

public class A : Base
{
    public string AName { get; set; }

    public override void Create(Processor p) => p.Process(this);
}

public class B : Base
{
    public string BName { get; set; }
    public override void Create(Processor p) => p.Process(this);
}
public class Processor
{
    public void Process(ICreate[] objs)
    {
        foreach (var obj in objs)
        {
            obj.Create(this);
        }
    }
    public void Process(A obj)
    {
        Console.WriteLine(obj.AName);
    }

    public void Process(B obj)
    {
        Console.WriteLine(obj.BName);
    }
}





