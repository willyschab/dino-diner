﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Triceritots : Side
    {
        private Size size;
        /// <summary>
        /// Sets the initial ingredients, price, and calories
        /// </summary>
        public Triceritots()
        {
            this.Price = 0.99;
            this.Calories = 352;
            this.Ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
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
                        this.Calories = 410;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 590;
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
