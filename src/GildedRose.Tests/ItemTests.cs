using GildedRose.Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GildedRose.Tests
{
    [TestClass]
    public class ItemTests
    {
        public void UpdateItem(Item expected, Item actual, int maxUpdateExecutions)
        {
            for (var i = 0; i < maxUpdateExecutions; i++)
                Program.UpdateQuality(new List<Item> { actual });

            Assert.IsTrue(actual.Equals(expected));
        }

        [TestMethod]
        public void DexterityVest()
        {
            var actualItem = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 };
            var expectedItem = new Item { Name = "+5 Dexterity Vest", SellIn = 5, Quality = 15 };
            UpdateItem(expectedItem, actualItem, 5);
        }

        [TestMethod]
        public void AgedBrie()
        {
            var actualItem = new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 };
            var expectedItem = new Item { Name = "Aged Brie", SellIn = -3, Quality = 8 };
            UpdateItem(expectedItem, actualItem, 5);
        }

        [TestMethod]
        public void MongooseElixir()
        {
            var actualItem = new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 };
            var expectedItem = new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 2 };
            UpdateItem(expectedItem, actualItem, 5);
        }

        [TestMethod]
        public void Sulfuras()
        {
            var actualItem = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 };
            var expectedItem = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 };
            UpdateItem(expectedItem, actualItem, 5);
        }

        [TestMethod]
        public void Tafkal80Etc()
        {
            var actualItem = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 };
            var expectedItem = new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = 38 };
            UpdateItem(expectedItem, actualItem, 11);
        }

        [TestMethod]
        public void ConjuredManaCakes()
        {
            var actualItem = new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 };
            var expectedItem = new Item { Name = "Conjured Mana Cake", SellIn = -2, Quality = 0 };
            UpdateItem(expectedItem, actualItem, 5);
        }
    }
}
