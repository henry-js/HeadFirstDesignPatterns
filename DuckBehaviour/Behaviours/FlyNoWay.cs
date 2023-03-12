using DuckBehaviour.Interfaces;

namespace DuckBehaviour.Behaviours;

public class FlyNoWay : IFlyBehaviour
{
    public void fly()
    {
        Console.WriteLine("I can't fly");
    }
}
