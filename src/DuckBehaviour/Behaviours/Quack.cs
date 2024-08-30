using DuckBehaviour.Interfaces;

namespace DuckBehaviour.Behaviours;

public class Quack : IQuackBehaviour
{
    public void quack()
    {
        Console.WriteLine("Quack");
    }
}

public class MuteQuack : IQuackBehaviour
{
    public void quack()
    {
        Console.WriteLine("<< Silence >>");
    }
}

public class Squeak : IQuackBehaviour
{
    public void quack()
    {
        Console.WriteLine("Squeak");
    }
}
