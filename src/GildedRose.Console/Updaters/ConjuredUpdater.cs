namespace GildedRose.Console.Updaters;
public class ConjuredUpdater: IItemUpdater{
    public void UpdateItem(Item item){
        DecreaseQuality(item,2);
        item.SellIn--;
        if (item.SellIn < 0)
            DecreaseQuality(item,2);
    }
    public void DecreaseQuality(Item item, int value){
        item.Quality = Math.Max(0, item.Quality - value);
    }
}