using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        private bool _sweet = false;
        private bool _lemon = false;
        private Size size;
        /// <summary>
        /// Property for adding sugar.
        /// </summary>
        public bool Sweet
        {
            get { return _sweet; }
            set { _sweet = value; }
        }
        /// <summary>
        /// Property for adding Lemon.
        /// </summary>
        public bool Lemon
        {
            get { return _lemon; }
            set { _lemon = value; }
        }
        /// <summary>
        /// Sets the default price, calories, ingredients, and Ice.
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
            this.Ingredients = new List<string>() { "Water", "Tea" };
            if (Sweet) Ingredients.Add("Cane Sugar");
            if (Lemon) Ingredients.Add("Lemon");
            this.Ice = true;
        }
        /// <summary>
        /// Allows the price and Calories to change when size changes.
        /// </summary>
        public Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Medium:
                        this.Price = 1.49;
                        this.Calories = 16;
                        break;
                    case Size.Large:
                        this.Price = 1.99;
                        this.Calories = 32;
                        break;
                    case Size.Small:
                        this.Price = .99;
                        this.Calories = 8;
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// Allows the addition of lemon.
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
        }
        /// <summary>
        /// Switches sugar to false when true and vice versa.
        /// </summary>
        public void SwitchSugar()
        {
            if(this.Sweet == true)
            {
                this.Sweet = false;
                this.Calories /= 2;
            }
            else
            {
                this.Sweet = true;
                this.Calories *= 2;
            }
            
        }
    }
}
