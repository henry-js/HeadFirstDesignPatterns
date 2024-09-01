namespace IteratorPattern;

public abstract class MenuComponent
{
    public virtual void Add(MenuComponent menuComponent) { throw new NotImplementedException(); }
    public virtual void Remove(MenuComponent menuComponent) { throw new NotImplementedException(); }
    public virtual MenuComponent GetChild(int i) { throw new NotImplementedException(); }
    public string Name { get; internal set; }
    public string Description { get; internal set; }
    public bool Vegetarian { get; internal set; }
    public double Price { get; internal set; }
    public abstract void Print();
}

// public record MenuItem(string Name, string Description, bool Vegetarian, double Price);

public class MenuItem : MenuComponent
{
    public MenuItem(string name, string description, bool vegetarian, double price)
    {
        Name = name;
        Description = description;
        Vegetarian = vegetarian;
        Price = price;
    }
    public override void Print()
    {
        Console.Write($" {Name}");
        if (Vegetarian) Console.Write("(v)");
        Console.WriteLine(", " + Price);
        Console.WriteLine(" -- " + Description);
    }
}

public class Menu : MenuComponent
{
    List<MenuComponent> menuComponents = new List<MenuComponent>();

    public Menu(String name, String description)
    {
        Name = name;
        Description = description;
    }
    public override void Add(MenuComponent menuComponent)
    {
        menuComponents.Add(menuComponent);
    }
    public override void Remove(MenuComponent menuComponent)
    {
        menuComponents.Remove(menuComponent);
    }
    public override MenuComponent GetChild(int i)
    {
        return menuComponents[i];
    }

    public override void Print()
    {
        Console.WriteLine("\n" + Name);
        Console.WriteLine(", " + Description);
        Console.WriteLine("---------------------");

        foreach (var component in menuComponents)
        {
            component.Print();
        }
    }
}
