using DuckBehaviour.Interfaces;

namespace DuckBehaviour.Ducks;

public abstract class Duck
{
    public IFlyBehaviour flyBehaviour = null!;
    public IQuackBehaviour quackBehaviour = null!;

    public abstract void Display();

    public void PerformFly() => flyBehaviour.fly();

    public void PerformQuack() => quackBehaviour.quack();

    public void Swim() => Console.WriteLine("All ducks float, even decoys!");

    public void SetFlyBehaviour(IFlyBehaviour fb) => flyBehaviour = fb;
    public void SetQuackBehaviour(IQuackBehaviour qb) => quackBehaviour = qb;
}
