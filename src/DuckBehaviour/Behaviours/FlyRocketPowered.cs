using DuckBehaviour.Interfaces;

namespace DuckBehaviour.Ducks;

public class FlyRocketPowered : IFlyBehaviour
{
    public void fly()
    {
        Console.WriteLine("I'm flying with a rocket!");
    }
}
