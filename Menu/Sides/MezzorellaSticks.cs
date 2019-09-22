using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class MezzorellaSticks : Side
    {
        public MezzorellaSticks()
        {
            this.Price = 0.99;
            this.Calories = 540;
            this.Ingredients = new List<string>() { "Vegetable Oil", "Cheese Product", "Breading" };
        }
        public override Size Size
        {
            set
            {
                switch (value)
                {
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 610;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 720;
                        break;
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 540;
                        break;
                }
            }
        }
    }
}
