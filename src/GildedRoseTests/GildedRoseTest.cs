using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void Foo()
    {
        List<Item> items = [ new Item { Name = "foo", SellIn = 0, Quality = 0 } ];
        GildedRose app = new(items);
        app.UpdateItems();
        Assert.Equal("foo", items[0].Name);
    }

    [Fact]
    public void IncreaseQuality_SellByDatePassed() 
    {
        List<Item> items = [new Item { Name = "Elixir of the Mongoose", SellIn = -1, Quality = 10 }];
        GildedRose app = new(items);
        app.UpdateItems();
        Assert.Equal("foo", items[0].Name);
    }

    public void IncreaseQuality_AgedBrieIncreaseQuality()
    {



    }

    public void IncreaseQuality_BackstagePass_10DaysOrLess()
    {

        /* can possibly just combine the backstagepass tests 
         and add separate items with different SellIn values and with separate asserts*/

    }

    public void IncreaseQuality_BackstagePass_5DaysOrLess()
    {

        /* can possibly just combine the backstagepass tests 
          and add separate items with different SellIn values and with separate asserts*/

    }

    public void IncreaseQuality_BackstagePass_ConcertPassed()
    {

        /* can possibly just combine the backstagepass tests 
          and add separate items with different SellIn values and with separate asserts*/    

    }
}
