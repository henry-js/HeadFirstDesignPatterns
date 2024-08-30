using DuckBehaviour.Behaviours;

namespace DuckBehaviour.Ducks;

public class ModelDuck : Duck
{
    public ModelDuck()
    {
        flyBehaviour = new FlyNoWay();
        quackBehaviour = new Quack();
    }
    public override void Display()
    {
        Console.WriteLine("I'm a model duck");
    }
}
