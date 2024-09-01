using System.Collections;

namespace IteratorPattern;

public class Waitress
{
    private readonly IEnumerable<IMenu> menus;

    public Waitress(params IMenu[] menus)
    {

        this.menus = menus;
    }
    public void PrintMenu()
    {
        var menuIterator = menus.GetEnumerator();
        while (menuIterator.MoveNext())
        {
            PrintMenu(menuIterator.Current.GetEnumerator());
        }

        static void PrintMenu(IEnumerator<MenuItem> iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = iterator.Current;
                Console.Write(menuItem.Name + ", £");
                Console.Write(menuItem.Price + " -- ");
                Console.WriteLine(menuItem.Description);
            }
        }
    }
}
