using System.Collections;
using System.ComponentModel;

namespace IteratorPattern;

public class DinerMenu : IMenu
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

    public IEnumerator<MenuItem> GetEnumerator() => new DinerMenuIterator(menuItems);

    // other menu methods here

    internal class DinerMenuIterator : IEnumerator<MenuItem>
    {
        readonly MenuItem[] _items;
        int _position = -1;

        public DinerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }

        public MenuItem Current => _items[_position] ?? throw new InvalidOperationException();
        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            _position++;
            return _position++ < _items.Length;
        }

        public void Reset() => _position = -1;

        public void Dispose() { }
    }
}

public class CafeMenu : IMenu
{
    Dictionary<string, MenuItem> items = [];

    public CafeMenu()
    {
        AddItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99);
        AddItem("Soup of the day", "A cup of the soup of the day, with a side salad", false, 3.69);
        AddItem("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29);
    }

    public void AddItem(string name, string description, bool vegetarian, double price)
    {
        MenuItem item = new(name, description, vegetarian, price);
        items.Add(name, item);
    }

    public IEnumerator<MenuItem> GetEnumerator() => items.Values.GetEnumerator();
}
public interface IMenu
{
    IEnumerator<MenuItem> GetEnumerator();
}
