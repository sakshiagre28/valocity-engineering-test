using System.Collections.Generic;
using GildedRose.Console.Updaters;
namespace GildedRose.Console;

public class Program
{
    public IList<Item> Items = new List<Item>();

    static void Main(string[] args)
    {
        System.Console.WriteLine("OMGHAI!");

        var app = new Program()
                      {
                          Items = ItemList.GetItems()

                      };

        app.UpdateQuality();
        System.Console.ReadKey();
    }

    public void UpdateQuality()
    {
        foreach(Item item in Items){
            var updater = ItemUpdaterFactory.GetUpdater(item);
            if(updater == null)
                continue;
            updater.UpdateItem(item);
        }
    }
}

