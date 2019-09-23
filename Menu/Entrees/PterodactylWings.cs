using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings : Entree
    {
        /// <summary>
        /// Sets the price, calories, and ingredients.
        /// </summary>
        public PterodactylWings()
        {
            this.Ingredients = new List<string>() { "Chicken", "Wing Sauce" };
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
