using DuckBehaviour.Behaviours;

namespace DuckBehaviour.Ducks;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        flyBehaviour = new FlyWithWings();
        quackBehaviour = new Quack();
    }

    public override void Display() => Console.WriteLine("I'm a real Mallard duck");
}
