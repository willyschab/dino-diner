using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;


namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// The enumerator for our flavors.
    /// </summary>
    public enum SodasaurusFlavor
    {
        Cola,
        Cherry,
        Chocolate,
        RootBeer,
        Vanilla,
        Orange,
        Lime
    }
    public abstract class Drink
    {
        
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public List<string> Ingredients { get; set; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public Size Size { get; set; }
        public SodasaurusFlavor SodasaurusFlavor { get; set; }

        public bool Ice { get; set; }

        public void HoldIce()
        {
            Ice = false;
        }
    }
}
