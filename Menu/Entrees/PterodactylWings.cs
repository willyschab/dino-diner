using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class PterodactylWings : Entree
    {
        public PterodactylWings()
        {
            this.Ingredients = new List<string>() { "Chicken", "Wing Sauce" };
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
