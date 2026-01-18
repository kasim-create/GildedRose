namespace GildedRoseKata;

public class GildedRose
{
    private IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    private void UpdateItemQuality(Item item)
    {
        switch (item.Name)
        {
            case "Aged Brie": 
                IncreaseQuality(item, 1);
                    break;

            case "Backstage passes to a TAFKAL80ETC concert":
                if (item.SellIn > 0)
                {
                    if (item.SellIn <= 10 && item.SellIn > 5)
                    {
                        IncreaseQuality(item, 2);
                    }
                    else if (item.SellIn <= 5)
                    {
                        IncreaseQuality(item, 3);
                    }
                    else
                    {
                        DecreaseQuality(item, 1);
                    }
                }
                else if (item.Quality > 0)
                {
                    DecreaseQuality(item, item.Quality);
                }
                    break;

            default:
                DecreaseQuality(item, 1);
                if (item.SellIn < 0)
                {
                    DecreaseQuality(item, 1);
                }
                break;
        };
    }

    private void IncreaseQuality(Item item, int amount)
    {
        if (item.Quality < 50)
        {
            item.Quality = item.Quality + amount;
        }
    }

    private void DecreaseQuality(Item item, int amount)
    {
        if (item.Quality > 0)
        {
            item.Quality = item.Quality - amount;
        }
    }
    

    public void UpdateItems()
    {

        foreach (var item in Items)
        {
            UpdateItemQuality(item);

        }

        //for (var i = 0; i < Items.Count; i++)
        //{
        //    if (Items[i].Name != "Aged Brie" && Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
        //    {
        //        if (Items[i].Quality > 0)
        //        {
        //            if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        //            {
        //                Items[i].Quality = Items[i].Quality - 1;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        if (Items[i].Quality < 50)
        //        {
        //            Items[i].Quality = Items[i].Quality + 1;

        //            if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
        //            {
        //                if (Items[i].SellIn < 11)
        //                {
        //                    if (Items[i].Quality < 50)
        //                    {
        //                        Items[i].Quality = Items[i].Quality + 1;
        //                    }
        //                }

        //                if (Items[i].SellIn < 6)
        //                {
        //                    if (Items[i].Quality < 50)
        //                    {
        //                        Items[i].Quality = Items[i].Quality + 1;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        //    {
        //        Items[i].SellIn = Items[i].SellIn - 1;
        //    }

        //    if (Items[i].SellIn < 0)
        //    {
        //        if (Items[i].Name != "Aged Brie")
        //        {
        //            if (Items[i].Name != "Backstage passes to a TAFKAL80ETC concert")
        //            {
        //                if (Items[i].Quality > 0)
        //                {
        //                    if (Items[i].Name != "Sulfuras, Hand of Ragnaros")
        //                    {
        //                        Items[i].Quality = Items[i].Quality - 1;
        //                    }
        //                }
        //            }
        //            else
        //            {
        //                Items[i].Quality = Items[i].Quality - Items[i].Quality;
        //            }
        //        }
        //        else
        //        {
        //            if (Items[i].Quality < 50)
        //            {
        //                Items[i].Quality = Items[i].Quality + 1;
        //            }
        //        }
        //    }
        //}
    }
}
