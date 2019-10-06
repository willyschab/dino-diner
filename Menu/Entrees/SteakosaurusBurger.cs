/*Author: Will Schabel
* Class: SteakosaurusBurger.cs
*/
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    public class SteakosaurusBurger : Entree
    {
        bool pickle = true;
        bool mustard = true;
        bool ketchup = true;
        bool bun = true;
        /// <summary>
        /// Sets up the ingredients.
        /// </summary>
        public override List<string> Ingredients
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
        /// <summary>
        /// Sets the price and calories.
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }
        /// <summary>
        /// Allows the removal of pickles
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// Allows the removal of mustard
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
        /// <summary>
        /// Allows the removal of ketchup
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        /// Allows the removal of the bun.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// Prints out the correct name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }
    }
}
