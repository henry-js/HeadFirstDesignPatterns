using Starbuzz.Beverages;

namespace Starbuzz.Condiments;

public abstract class CondimentDecorator : Beverage
{
    protected Beverage _beverage;
    public abstract override string GetDescription();
}
