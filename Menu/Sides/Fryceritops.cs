using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        public Fryceritops()
        {
            this.Ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
            this.Price = 0.99;
            this.Calories = 222;
        }
        
        public override Size Size
        {
            set
            {
                switch (value)
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
                        this.Calories = 222;
                        break;
                }
            }
        }
    }
}
