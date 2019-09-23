using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Creates the class Brontowurst
    /// </summary>
    public class Brontowurst : Entree
    {
        private bool peppers = true;
        private bool onions = true;
        private bool wholeWheatBun = true;

        /// <summary>
        /// Builds the ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                return ingredients;
            }
        }

        /// <summary>
        /// Sets the price and calories.
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        /// <summary>
        /// Allows the removal of peppers.
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }
        /// <summary>
        /// Allows the removal of onions.
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
        /// <summary>
        /// Allows the removal of a bun.
        /// </summary>
        public void HoldBun()
        {
            this.wholeWheatBun = false;
        }
    }
}
