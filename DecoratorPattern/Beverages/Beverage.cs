namespace Starbuzz.Beverages;
public abstract class Beverage
{
    protected string _description = "Unknown Beverage";
    private Size _size = Size.TALL;

    public virtual string GetDescription() => _description;
    public abstract double Cost();

    public override string ToString()
    {
        return $"Cost: £{Math.Round(Cost(), 2)}. Drink: {GetSize()} {GetDescription()}.";
    }
    public Size GetSize() => _size;
    public virtual void SetSize(Size size)
    {
        _size = size;
    }

    public enum Size
    {
        TALL, GRANDE, VENTI
    }
}

public class Espresso : Beverage
{
    public Espresso() => _description = "Espresso";
    public override double Cost() => 1.99;
}

public class HouseBlend : Beverage
{
    public HouseBlend() => _description = "House Blend Coffee";
    public override double Cost() => .89;
}
public class DarkRoast : Beverage
{
    public DarkRoast() => _description = "Dark Roasted Coffee";
    public override double Cost() => .99;
}
public class Decaff : Beverage
{
    public Decaff() => _description = "Coffee without the caffeine";
    public override double Cost() => 1.05;
}
