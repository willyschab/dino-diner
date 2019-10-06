/*Author: Will Schabel
* Class: Sodasaurus.cs
*/
using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink
    {
        private Size size;
        public SodasaurusFlavor SodasaurusFlavor { get; set; }
        /// <summary>
        /// Sets the default ingredients, price, calories, and ice.
        /// </summary>
        public Sodasaurus()
        {
            this.Price = 1.50;
            this.Calories = 112;
            this.Ice = true;
        }
        /// <summary>
        /// Builds the ingredients and makes them immutable.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
                return ingredients;
            }
        }
        /// <summary>
        /// Changes the calories and price when size is changed.
        /// </summary>
        public Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Medium:
                        this.Price = 2.00;
                        this.Calories = 156;
                        break;
                    case Size.Large:
                        this.Price = 2.50;
                        this.Calories = 208;
                        break;
                    case Size.Small:
                        this.Price = 1.50;
                        this.Calories = 112;
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

            return $"{size} {SodasaurusFlavor} Sodasaurus";
        }
    }
}
