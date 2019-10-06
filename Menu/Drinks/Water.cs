/*Author: Will Schabel
* Class: Water.cs
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink
    {
        private Size size;
        private string sizeString;
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
            if (Lemon) Ingredients.Add("Lemon");
            this.Ice = true;
        }
        /// <summary>
        /// Builds the ingredients and makes them immutable.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                return ingredients;
            }
        }
        public Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Medium:
                        this.sizeString = "Medium";
                        break;
                    case Size.Large:
                        this.sizeString = "Large";
                        break;
                    case Size.Small:
                        this.sizeString = "Small";
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// Allows the addition of Lemon.
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }
        /// <summary>
        /// Returns the correct name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return sizeString + " Water";
        }
    }
}
