using System.Collections;

namespace IteratorPattern;

public class PancakeHouseMenu
{
    readonly List<MenuItem> menuItems = [];
    public PancakeHouseMenu()
    {
        AddItem("K&B's Pancake Breakfast",
        "Pancakes with scrambled eggs and toast",
        true,
        2.99);
        AddItem("Regular Pancake Breakfast",
        "Pancakes with fried eggs, sausage",
        false,
        2.99);
        AddItem("Blueberry Pancakes",
        "Pancakes made with fresh blueberries",
        true,
        3.49);
        AddItem("Waffles",
        "Waffles with your choice of blueberries or strawberries",
        true,
        3.59);
    }

    public void AddItem(string name, string description, bool vegetarian, double price)
    {
        MenuItem menuItem = new(name, description, vegetarian, price);
        menuItems.Add(menuItem);
    }

    public List<MenuItem> GetMenuItems()
    {
        return [.. menuItems];
    }
}
