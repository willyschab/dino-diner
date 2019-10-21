﻿/*Author: Will Schabel
* Class: Drink.cs
*/
using System;
using System.Collections.Generic;
using System.Text;


namespace DinoDiner.Menu 
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
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// Gets the price.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Gets the calories.
        /// </summary>
        public uint Calories { get; set; }
        public virtual List<string> Ingredients { get; set; }
        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public Size Size { get; set; }
        /// <summary>
        /// Get ands sets the flavor.
        /// </summary>
        public SodasaurusFlavor SodasaurusFlavor { get; set; }
        /// <summary>
        /// Get's and set the ice bool.
        /// </summary>
        public bool Ice { get; set; }
        /// <summary>
        /// Gets or sets Special orders of the item.
        /// </summary>
        public string[] Special { get; set; }
        /// <summary>
        /// Gets or sets the description of the item.
        /// </summary>
        public string Description { get; }
    }
}
