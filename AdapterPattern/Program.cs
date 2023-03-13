using System.Data;
using AdapterPattern;

IDuck duck = new MallardDuck();

ITurkey turkey = new WildTurkey();
IDuck turkeyAdapter = new TurkeyAdapter(turkey);

System.Console.WriteLine("The tukey says...");
turkey.Gobble();
turkey.Fly();

System.Console.WriteLine("\nThe Duck says...");
testDuck(duck);

System.Console.WriteLine("\nThe TurkeyAdapter says...");
testDuck(turkeyAdapter);

static void testDuck(IDuck duck)
{
    duck.Quack();
    duck.Fly();
}
