/*Author: Will Schabel
* Class: Water.cs
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink, INotifyPropertyChanged
    {
        private Size size;
        private bool _lemon = false;
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
        /// Property for adding lemon.
        /// </summary>
        public bool Lemon
        {
            get { return _lemon; }
            set { _lemon = value; }
        }
        /// <summary>
        /// Sets the default price, calories, ingredients, and ice.
        /// </summary>
        public Water()
        {
            this.Price = 0.10;
            this.Calories = 0;
            if (Lemon) Ingredients.Add("Lemon");
            this.Ice = true;
        }
        /// <summary>
        /// Builds the ingredients and makes them immutable.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                return ingredients;
            }
        }
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Medium:
                        size = Size.Medium;
                        NotifyOfPropertyChange("Description");
                        break;

                    case Size.Large:
                        size = Size.Large;
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Small:
                        size = Size.Small;
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
        /// Allows the addition of Lemon.
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Returns the correct name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} Water";
        }
        /// <summary>
        /// Returns the description of the item.
        /// </summary>
        public string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// Gets any special preparation instructions
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Lemon) special.Add("Add Lemon");
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
    }
}
