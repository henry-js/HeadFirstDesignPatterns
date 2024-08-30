using Starbuzz.Beverages;

namespace Starbuzz.Condiments;

public class Whip : CondimentDecorator
{
    public Whip(Beverage beverage)
    {
        _beverage = beverage;
    }
    public override double Cost() => _beverage.Cost() + .15;

    public override string GetDescription() => _beverage.GetDescription() + ", Whip";
}
