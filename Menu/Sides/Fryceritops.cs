using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        private Size size;
        /// <summary>
        /// Sets the initial ingredient, price, and calories.
        /// </summary>
        public Fryceritops()
        {
            this.Ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            this.Price = 0.99;
            this.Calories = 222;
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
                        this.Calories = 365;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 480;
                        break;
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 352;
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
