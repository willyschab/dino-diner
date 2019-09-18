using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {
        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 222;
            this.Ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
        }
    }
}
