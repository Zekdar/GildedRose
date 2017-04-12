using GildedRose.Console.ItemStrategy.Interface;

namespace GildedRose.Console.ItemStrategy
{
    public class Context
    {
        public IUpdateQuality Strategy { get; set; }

        public Context(IUpdateQuality strategy)
        {
            Strategy = strategy;
        }

        public void UpdateQuality(Item item)
        {
            Strategy.UpdateQuality(item);
        }
    }
}
