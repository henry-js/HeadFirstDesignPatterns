using System.Collections;

namespace IteratorPattern;

public class Waitress
{
    private readonly PancakeHouseMenu pancakeHouseMenu;
    private readonly DinerMenu dinerMenu;

    public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
    {
        this.pancakeHouseMenu = pancakeHouseMenu;
        this.dinerMenu = dinerMenu;
    }
    public void PrintMenu()
    {
        IEnumerable<MenuItem> breakfastItems = pancakeHouseMenu.GetMenuItems();

        IEnumerable<MenuItem> lunchItems = dinerMenu.GetMenuItems();

        PrintMenu(breakfastItems);
        PrintMenu(lunchItems);

        static void PrintMenu(IEnumerable<MenuItem> items)
        {
            foreach (var menuItem in items)
            {
                Console.Write(menuItem.Name);
                Console.WriteLine(menuItem.Price);
                Console.WriteLine(menuItem.Description);
            }
        }
    }
}
