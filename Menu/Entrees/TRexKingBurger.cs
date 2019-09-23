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
        /// <summary>
        /// Sets up the ingredients.
        /// </summary>
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
        /// <summary>
        /// Sets the price and calories
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }
        /// <summary>
        /// Allows the removal of a bun.
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }
        /// <summary>
        /// Allows the removal of the pickle.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// Allows the removal of the onion.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }
        /// <summary>
        /// Allows the removal of mayonnaise.
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }
        /// <summary>
        /// Allows the removal of lettuce.
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// <summary>
        /// Allows the removal of ketchup.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        /// Allows the removal of mustard
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
        /// <summary>
        /// Allows the removal of the bun.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

    }
}
