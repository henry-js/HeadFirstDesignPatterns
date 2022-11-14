using DuckBehaviour.Interfaces;

namespace DuckBehaviour.Behaviours;

public class FlyWithWings : IFlyBehaviour
{
    public void fly()
    {
        Console.WriteLine("I'm flying!!");
    }

}
