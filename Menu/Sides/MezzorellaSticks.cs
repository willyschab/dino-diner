/*Author: Will Schabel
* Class: MezzorellaSticks.cs
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class MezzorellaSticks : Side
    {
        private Size size;
        private string sizeString;
        /// <summary>
        /// Sets the initial ingredients, price, and calories
        /// </summary>
        public MezzorellaSticks()
        {
            this.Price = 0.99;
            this.Calories = 540;
        }
        /// <summary>
        /// Creates the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Vegetable Oil", "Cheese Product", "Breading" };
                return ingredients;
            }
        }
        /// <summary>
        /// Allows the changing of size.
        /// </summary>
        public Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 610;
                        sizeString = "Medium";
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 720;
                        sizeString = "Large";
                        break;
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 352;
                        sizeString = "Small";
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// Prints out the correct name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return sizeString + " Mezzorella Sticks";
        }
    }
}
