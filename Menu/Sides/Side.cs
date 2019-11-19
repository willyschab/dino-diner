/*Author: Will Schabel
* Class: Side.cs
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{

    public abstract class Side : Menu, IOrderItem, INotifyPropertyChanged
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
        public virtual Size Size { get; set; }
        /// <summary>
        /// Gets or sets Special orders of the item.
        /// </summary>
        public virtual string[] Special { get; set; }
        /// <summary>
        /// Gets or sets the description of the item.
        /// </summary>
        public virtual string Description { get; set; }
        public string Name { get; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
