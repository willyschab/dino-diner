/*Author: Will Schabel
* Class: Sodasaurus.cs
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    public class Sodasaurus : Drink, INotifyPropertyChanged
    {
        private Size size;
        private SodasaurusFlavor flavor;

        /// <summary>
        /// The PorpertyChanged event handler; notifies of changes to the Price, Description, and Special properties.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        // Helper function for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override SodasaurusFlavor SodasaurusFlavor
        {
            set
            {
                flavor = value;
                NotifyOfPropertyChange("Description");
            }
            get
            {
                return flavor;
            }
        }
        /// <summary>
        /// Sets the default ingredients, price, calories, and ice.
        /// </summary>
        public Sodasaurus()
        {
            this.Price = 1.50;
            this.Calories = 112;
            this.Ice = true;
        }
        /// <summary>
        /// Builds the ingredients and makes them immutable.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
                return ingredients;
            }
        }
        /// <summary>
        /// Gets a description of this order tiem
        /// </summary>
        public string Description
        {
            get { return this.ToString();  }

        }
        /// <summary>
        /// Allows the removal of ice.
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Gets the special instructions for this order item
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Changes the calories and price when size is changed.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Medium:
                        this.Price = 2.00;
                        this.Calories = 156;
                        size = Size.Medium;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Large:
                        this.Price = 2.50;
                        this.Calories = 208;
                        size = Size.Large;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Small:
                        this.Price = 1.50;
                        this.Calories = 112;
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

            return $"{size} {SodasaurusFlavor} Sodasaurus";
        }
    }
}
