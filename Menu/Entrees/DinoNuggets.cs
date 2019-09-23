using System.Collections.Generic;
namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets : Entree
    {
        public int  NuggetCount { get; set; }
        /// <summary>
        /// sets up the ingredients.
        /// </summary>
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
        /// <summary>
        /// Sets the price, number of nuggets being purchased, and calories.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.NuggetCount = 6;
            this.Calories = 59 * 6;
        }
        /// <summary>
        /// This method allows the user to add more nuggets to their order.
        /// </summary>
        public void AddNugget()
        {
            this.NuggetCount++;
            this.Price += .25;
            this.Calories += 59;
        }
    }
}
