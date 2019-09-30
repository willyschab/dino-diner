using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        private Size size;
        private bool _lemon = false;
        /// <summary>
        /// Property for adding lemon.
        /// </summary>
        public bool Lemon
        {
            get { return _lemon; }
            set { _lemon = value; }
        }
        /// <summary>
        /// Sets the default price, calories, ingredients, and ice.
        /// </summary>
        public Water()
        {
            this.Price = 0.10;
            this.Calories = 0;
            this.Ingredients = new List<string>() { "Water" };
            if (Lemon) Ingredients.Add("Lemon");
            this.Ice = true;
        }
        /// <summary>
        /// Allows the addition of Lemon.
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }
    }
}
