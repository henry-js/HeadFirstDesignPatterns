namespace IteratorPattern;

public class DinerMenu
{
    const int MAX_ITEMS = 4;
    readonly MenuItem[] menuItems;
    int itemCount;

    public DinerMenu()
    {
        menuItems = new MenuItem[MAX_ITEMS];
        AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
        AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
        AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
        AddItem("Hotdog", "A hot dog, with sauerkraut, relish, onions, topped with cheese", false, 3.05);
        // a couple of other Diner Menu items added here
    }

    public void AddItem(string name, string description, bool vegetarian, double price)
    {
        MenuItem menuItem = new(name, description, vegetarian, price);
        if (itemCount >= MAX_ITEMS)
        {
            Console.Error.WriteLine("Sorry, menu is full! Can't add item to menu");
        }
        else
        {
            menuItems[itemCount] = menuItem;
            itemCount++;
        }
    }

    public IEnumerable<MenuItem> GetMenuItems()
    {
        return menuItems;
    }
    // other menu methods here
}
