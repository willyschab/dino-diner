using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger
    {
        bool pickle = true;
        bool mustard = true;
        bool ketchup = true;
        bool bun = true;

        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (pickle) ingredients.Add("Pickle");
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (mustard) ingredients.Add("Mustard");
                if (ketchup) ingredients.Add("Ketchup");
                return ingredients;
            }
        }

        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        public void HoldPickle()
        {
            this.pickle = false;
        }

        public void HoldMustard()
        {
            this.mustard = false;
        }

        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        public void HoldBun()
        {
            this.bun = false;
        }
    }
}
