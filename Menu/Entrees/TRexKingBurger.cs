using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger : Entree
    {
        bool tomato = true;
        bool pickle = true;
        bool onion = true;
        bool mayo = true;
        bool lettuce = true;
        bool ketchup = true;
        bool mustard = true;
        bool bun = true;

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (tomato) ingredients.Add("Tomato");
                if (pickle) ingredients.Add("Pickle");
                if (onion) ingredients.Add("Onion");
                if (mayo) ingredients.Add("Mayo");
                if (lettuce) ingredients.Add("Lettuce");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (bun) ingredients.Add("Whole Wheat Bun");
                return ingredients;
            }
        }

        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        public void HoldTomato()
        {
            this.tomato = false;
        }

        public void HoldPickle()
        {
            this.pickle = false;
        }

        public void HoldOnion()
        {
            this.onion = false;
        }

        public void HoldMayo()
        {
            this.mayo = false;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        public void HoldMustard()
        {
            this.mustard = false;
        }

        public void HoldBun()
        {
            this.bun = false;
        }

    }
}
