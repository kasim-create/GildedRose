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
                if (item.SellIn < 0)
                {
                    IncreaseQuality(item, 1);
                }
                    break;

            case "Backstage passes to a TAFKAL80ETC concert":
                if (item.SellIn >= 0)
                {
                    IncreaseQuality(item, 1);

                    if (item.SellIn < 10)
                    {
                        IncreaseQuality(item, 1);
                    }
                    if (item.SellIn < 5)
                    {
                        IncreaseQuality(item, 1);
                    }
                }
                else if (item.Quality > 0 && item.SellIn < 0)
                {
                    DecreaseQuality(item, item.Quality);
                }
                    break;

            case "Conjured Mana Cake" :
                DecreaseQuality(item, 2);
                if (item.SellIn < 0)
                {
                    DecreaseQuality(item, 2);
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

    private void UpdateSellIn(Item item)
    {
        item.SellIn--;
    }
    

    public void UpdateItems()
    {

        foreach (var item in Items)
        {
            if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                continue;
            }

            UpdateSellIn(item);
            UpdateItemQuality(item);

        }

        //for (var i = 0; i < Items.Count; i++)
        //{
        //      ***NORMAL ITEMS***
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
        //    {     ***"Aged Brie" AND BACKSTAGE PASS***
        //        if (Items[i].Quality < 50) QUALITY NEVER EXCEEDS 50
        //        {
        //            Items[i].Quality = Items[i].Quality + 1;
                       
                       //BACKSTAGE PASS ADDITIONAL QUALITY INCREASES
        //            if (Items[i].Name == "Backstage passes to a TAFKAL80ETC concert")
        //            {
        //                if (Items[i].SellIn < 11) 10 DAYS REMAINING GET ADDITIONAL +1
        //                {
        //                    if (Items[i].Quality < 50)
        //                    {
        //                        Items[i].Quality = Items[i].Quality + 1;
        //                    }
        //                }

        //                if (Items[i].SellIn < 6) 5 DAYS REMAINING GET ADDITIONAL +1
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
                                  //REDUCE NORMAL ITEM QUALITY TWICE AS FAST AS SELL IN IS LESS THAN 0 
        //                        Items[i].Quality = Items[i].Quality - 1;
        //                    }
        //                }
        //            }
        //            else
        //            {
                           //DEDUCT QUALITY BY ITSELF AS QUALITY IS NEVER LOWER THAN 0
        //                Items[i].Quality = Items[i].Quality - Items[i].Quality;
        //            }
        //        }
        //        else
        //        {
        //            if (Items[i].Quality < 50)
        //            {
                            //INCREASE QUALITY IF IN DATE
        //                Items[i].Quality = Items[i].Quality + 1;
        //            }
        //        }
        //    }
        //}
    }
}
