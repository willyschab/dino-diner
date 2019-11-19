/*Author: Will Schabel
* Class: Triceritots.cs
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Triceritots : Side, INotifyPropertyChanged
    {
        private Size size;
        /// <summary>
        /// The PorpertyChanged event handler; notifies of changes to the Price, Description, and Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        // Helper function for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Sets the initial ingredients, price, and calories
        /// </summary>
        public Triceritots()
        {
            this.Price = 0.99;
            this.Calories = 352;
        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
                return ingredients;
            }
        }
        /// <summary>
        /// Allows the changing of size.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 410;
                        size = Size.Medium;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 590;
                        size = Size.Large;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 352;
                        size = Size.Small;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        NotifyOfPropertyChange("Description");
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// Prints out the correct name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} Triceritots";
        }
        /// <summary>
        /// Returns the description of the item.
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }
        public string Name()
        {
            return $"Triceritots";
        }
        /// <summary>
        /// Gets any special preparation instructions
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }
    }
}
