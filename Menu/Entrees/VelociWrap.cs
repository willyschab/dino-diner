﻿using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {
        private bool peppers = true;
        private bool onions = true;
        private bool wholeWheatBun = true;
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onions");
                if (wholeWheatBun) ingredients.Add("Whole Wheat Bun");
                return ingredients;
            }
        }

        public VelociWrap()
        {
            this.Price = 4.25;
            this.Calories = 59;
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }

        public void HoldOnion()
        {
            this.onions = false;
        }

        public void HoldBun()
        {
            this.wholeWheatBun = false;
        }
    }
}