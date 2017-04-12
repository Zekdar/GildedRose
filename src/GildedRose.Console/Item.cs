namespace GildedRose.Console
{
    public class Item
    {
        public override bool Equals(object obj)
        {
            var item = (Item)obj;
            return Name == item.Name && SellIn == item.SellIn && Quality == item.Quality;
        }

        public string Name { get; set; }

        public int SellIn { get; set; }

        public int Quality { get; set; }
    }
}