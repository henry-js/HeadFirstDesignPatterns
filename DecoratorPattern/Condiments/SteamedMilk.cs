using Starbuzz.Beverages;

namespace Starbuzz.Condiments;

public class SteamedMilk : CondimentDecorator
{
    public SteamedMilk(Beverage beverage)
    {
        _beverage = beverage;
    }
    public override double Cost() => _beverage.Cost() + .15;

    public override string GetDescription() => _beverage.GetDescription() + ", Steamed Milk";
}
