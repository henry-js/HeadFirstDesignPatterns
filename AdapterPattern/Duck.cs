namespace AdapterPattern;

public interface IDuck
{
    public void Quack();
    public void Fly();
}

public class MallardDuck : IDuck
{
    public void Fly()
    {
        Console.WriteLine("I'm flying");
    }

    public void Quack()
    {
        Console.WriteLine("Quack");
    }
}

public interface ITurkey
{
    public void Gobble();
    public void Fly();
}

public class WildTurkey : ITurkey
{
    public void Fly()
    {
        System.Console.WriteLine("I'm flying a short distance");
    }

    public void Gobble()
    {
        System.Console.WriteLine("Gobble gobble");
    }
}

public class TurkeyAdapter : IDuck
{
    ITurkey turkey;

    public TurkeyAdapter(ITurkey turkey)
    {
        this.turkey = turkey;
    }

    public void Fly()
    {
        for (int i = 0; i < 5; i++)
        {
            turkey.Fly();
        }
    }

    public void Quack()
    {
        turkey.Gobble();
    }
}
