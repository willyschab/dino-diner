using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap : Entree
    {
        bool cheese = true;
        bool dressing = true;
        bool lettuce = true;

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast"};
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldDressing()
        {
            this.dressing = false;
        }

        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
