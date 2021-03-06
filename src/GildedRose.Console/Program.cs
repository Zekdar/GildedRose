﻿using System.Collections.Generic;

namespace GildedRose.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20},
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            UpdateQuality(items);

            System.Console.ReadKey();
        }

        public static void UpdateQuality(List<Item> items)
        {
            foreach (Item item in items)
            {
                if (item.Name != "Aged Brie"
                    && item.Name != "Backstage passes to a TAFKAL80ETC concert"
                    && item.Name != "Sulfuras, Hand of Ragnaros"
                    && item.Quality > 0)
                {
                    item.Quality--;
                }
                else
                {
                    if (item.Quality < 50)
                    {
                        item.Quality++;

                        if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                        {
                            if (item.SellIn < 11 && item.Quality < 50)
                            {
                                item.Quality++;
                            }

                            if (item.SellIn < 6 && item.Quality < 50)
                            {
                                item.Quality++;
                            }
                        }
                    }
                }

                if (item.Name != "Sulfuras, Hand of Ragnaros")
                    item.SellIn--;

                if (item.SellIn < 0)
                {
                    if (item.Name != "Aged Brie")
                    {
                        if (item.Name != "Sulfuras, Hand of Ragnaros"
                            && item.Name != "Backstage passes to a TAFKAL80ETC concert"
                            && item.Quality > 0)
                        {
                            item.Quality--;
                        }
                        else
                        {
                            item.Quality = 0;
                        }
                    }
                    else if (item.Quality < 50)
                    {
                        item.Quality++;
                    }
                }
            }
        }
    }
}
