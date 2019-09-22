using System.Collections.Generic;
namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : Entree
    {
        public int  NuggetCount { get; set; }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                for (int i = 0; i < NuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
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
            this.NuggetCount++;
            this.Price += .25;
            this.Calories += 59;
        }
    }
}
