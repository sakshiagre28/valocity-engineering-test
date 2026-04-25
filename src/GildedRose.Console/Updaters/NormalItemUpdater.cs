namespace GildedRose.Console.Updaters;
public class NormalItemUpdater: IItemUpdater{
    public void UpdateItem(Item item){
        DecreaseQuality(item,1);
        item.SellIn--;
        if(item.SellIn < 0){
            DecreaseQuality(item, 1);
        }
    }

    public void DecreaseQuality(Item item, int value){
        item.Quality = Math.Max(0, item.Quality - value);
    }
} 