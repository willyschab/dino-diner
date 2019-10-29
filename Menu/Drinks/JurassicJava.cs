/*Author: Will Schabel
* Class: JurassicJava.cs
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink, INotifyPropertyChanged
    {
        private bool _roomForCream = false;
        private bool _decaf = false;
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
        /// Sets our roomforcream property to it's default value, and allows it to be set.
        /// </summary>
        public bool RoomForCream
        {
            get { return _roomForCream; }
            set { _roomForCream = value; }
        }
        /// <summary>
        /// Sets the default value for decaf and allows it to be set.
        /// </summary>
        public bool Decaf
        {
            get { return _decaf;  }
            set
            {
                _decaf = value;
                NotifyOfPropertyChange("Description");
            }
        }
        /// <summary>
        /// Sets the default price, calories, ingredients, and ice.
        /// </summary>
         public JurassicJava()
        {
            this.Price = .59;
            this.Calories = 2;
            this.Ice = false;
        }
        /// <summary>
        /// Builds the ingredients and makes them immutable.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Coffee" };
                return ingredients;
            }
        }
        /// <summary>
        /// Allows the RoomForCream variable to be switched to true.
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }
        /// <summary>
        /// Allows the addition of ice.
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Changes the price and calories when size is changed.
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Medium:
                        this.Price = .99;
                        this.Calories = 4;
                        size = Size.Medium;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Large:
                        this.Price = 1.49;
                        this.Calories = 8;
                        size = Size.Large;
                        NotifyOfPropertyChange("Price");
                        NotifyOfPropertyChange("Calories");
                        NotifyOfPropertyChange("Description");
                        break;
                    case Size.Small:
                        this.Price = .59;
                        this.Calories = 2;
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
        /// Prints out the correct name for the drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return  $"{size} Decaf Jurassic Java";
            }
            else
            {
                return $"{size} Jurassic Java";

            }
        }
        /// <summary>
        /// Returns the descprition of the item.
        /// </summary>
        public string Description
        {
            get
            {
                List<string> ingredients = new List<string>();
                return this.ToString();
            }
        }
        /// <summary>
        /// Gets any special preperation instructions.
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (Ice) special.Add("Add Ice");
                return special.ToArray();
            }
        }
    }
}
