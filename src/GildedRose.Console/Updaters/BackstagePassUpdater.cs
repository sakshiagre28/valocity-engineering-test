namespace GildedRose.Console.Updaters;
public class BackstagePassUpdater: IItemUpdater{
    public void UpdateItem(Item item){
        IncreaseQuality(item,1);

        if(item.SellIn < 11){
            IncreaseQuality(item,1);
        }
        if(item.SellIn < 6){
            IncreaseQuality(item,1);
        }
        item.SellIn--;
        if (item.SellIn < 0)
            item.Quality = 0;
    }
    public void IncreaseQuality(Item item, int value){
        item.Quality = Math.Min(50, item.Quality + value);
    }
}