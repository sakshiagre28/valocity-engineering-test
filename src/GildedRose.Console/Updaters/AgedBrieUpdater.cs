namespace GildedRose.Console.Updaters;
public class AgedBrieUpdater: IItemUpdater{
    public void UpdateItem(Item item){
        IncreaseQuality(item,1);
        item.SellIn--;
        if (item.SellIn < 0)
            IncreaseQuality(item, 1);
    }
    public void IncreaseQuality(Item item, int value){
        item.Quality = Math.Min(50, item.Quality + value);
    }
}