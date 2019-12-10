/*Author: Will Schabel
* Class: Tyrannotea.cs
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink, IOrderItem, INotifyPropertyChanged
    {
        private bool _sweet = false;
        private bool _lemon = false;
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
        /// Property for adding sugar.
        /// </summary>
        public bool Sweet
        {
            get { return _sweet; }
            set
            {
                _sweet = value;
                NotifyOfPropertyChange("Description");
            }
        }
        /// <summary>
        /// Property for adding Lemon.
        /// </summary>
        public bool Lemon
        {
            get { return _lemon; }
            set {
                _lemon = value;;
            }
        }
        /// <summary>
        /// Sets the default price, calories, ingredients, and Ice.
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
            if (Sweet) Ingredients.Add("Cane Sugar");
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
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                return ingredients;
            }
        }
        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Allows the price and Calories to change when size changes.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Medium:
                        this.Price = 1.49;
                        this.Calories = 16;
                        size = Size.Medium;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Large:
                        this.Price = 1.99;
                        this.Calories = 32;
                        size = Size.Large;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Small:
                        this.Price = .99;
                        this.Calories = 8;
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
        /// Allows the addition of lemon.
        /// </summary>
        public void AddLemon()
        {
            this.Lemon = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Switches sugar to false when true and vice versa.
        /// </summary>
        public void SwitchSugar()
        {
            if(this.Sweet == true)
            {
                this.Sweet = false;
                this.Calories /= 2;
            }
            else
            {
                this.Sweet = true;
                this.Calories *= 2;
            }
            
        }
        /// <summary>
        /// Prints out the correct name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Sweet)
            {
                return $"{size} Sweet Tyrannotea";
            }
            else
            {
                return $"Tyrannotea";
            }
        }
        /// <summary>
        /// Gets a description of this order tiem
        /// </summary>
        public override string Description
        {
            get { return this.ToString(); }

        }
        /// <summary>
        /// Gets the special instructions for this order item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                if (Lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }
    }
}
