using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    private const string BackStagePass = "Backstage passes to a TAFKAL80ETC concert";
    private const string AgedBrie = "Aged Brie";
    private const string ElixirOfTheMongoose = "Elixir of the Mongoose";

    [Fact]
    public void Foo()
    {
        List<Item> items = [ new Item { Name = "foo", SellIn = 0, Quality = 0 } ];
        GildedRose app = new(items);
        app.UpdateItems();
        Assert.Equal("foo", items[0].Name);
    }

    [Fact]
    public void IncreaseQuality_SellByDatePassed_SellInIsNegative() 
    {
        List<Item> items = [new Item { Name = ElixirOfTheMongoose, SellIn = -1, Quality = 10 }];
        GildedRose app = new(items);
        app.UpdateItems();
        Assert.Equal(8, items[0].Quality);
    }

    [Fact]
    public void IncreaseQuality_SellByDatePassed_SellInIsZero()
    {
        List<Item> items = [new Item { Name = ElixirOfTheMongoose, SellIn = 0, Quality = 10 }];
        GildedRose app = new(items);
        app.UpdateItems();
        Assert.Equal(9, items[0].Quality);
    }

    [Fact]
    public void IncreaseQuality_AgedBrieIncreaseQuality()
    {
        List<Item> items = [new Item { Name = AgedBrie, SellIn = 10, Quality = 10 }];
        GildedRose app = new(items);
        app.UpdateItems();
        Assert.Equal(11, items[0].Quality);
    }

    [Fact]
    public void IncreaseQuality_BackstagePass_10DaysOrLess()
    {
        List<Item> items =
            [
            new Item { Name = BackStagePass, SellIn = 10, Quality = 10 },
            new Item { Name = BackStagePass, SellIn = 5, Quality = 5 },
            new Item { Name = BackStagePass, SellIn = -1, Quality = 5 }
            ];

        GildedRose app = new(items);
        app.UpdateItems();
        Assert.Equal(12, items[0].Quality);
        Assert.Equal(8, items[1].Quality);
        Assert.Equal(0, items[2].Quality);
    }
}
