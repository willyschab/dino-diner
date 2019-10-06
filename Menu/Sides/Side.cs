/*Author: Will Schabel
* Class: Side.cs
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{

    public abstract class Side : IMenuItem
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
        public virtual List<string> Ingredients { get; set; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public Size Size { get; set; }

    }
}
