using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        public double Price { get; set; }
        public uint Calories { get; set; }
        public int  NuggetCount { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken Nugget" };
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.NuggetCount = 6;
            this.Calories = 59 * 6;
        }

        public void AddNugget()
        {
            NuggetCount++;
            this.Price += (NuggetCount - 6) * .25;
        }
    }
}
