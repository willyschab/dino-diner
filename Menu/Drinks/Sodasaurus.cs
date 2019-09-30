using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
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
            this.Ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            this.Price = 1.50;
            this.Calories = 112;
            this.Ice = true;
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
    }
}
