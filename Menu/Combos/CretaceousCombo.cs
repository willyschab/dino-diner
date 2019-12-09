/*Author: Will Schabel
* Class: CretaceousCombo.cs
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : Menu, IOrderItem, INotifyPropertyChanged
    {
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

        /// <summary>
        /// Gets the entree.
        /// </summary>
        public Entree Entree { get; set; }
        /// <summary>
        /// Gets the drink.
        /// </summary>
        public Drink Drink { get; set; }
        /// <summary>
        /// Gets the side.
        /// </summary>
        public Side Side { get; set; }
        private Size size;
        /// <summary>
        /// Sets the size.
        /// </summary>
        public Size Size {
            get { return size; }
            set {
                this.size = value;
                this.Drink.Size = value;
                this.Side.Size = value;
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Ingredients");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Special");
            }
        }
        /// <summary>
        /// Gets and calculates the price.
        /// </summary>
        public double Price
        {
            get
            {
                return Drink.Price + Side.Price + Entree.Price - 0.25;
            }
        }
        /// <summary>
        /// Gets and calculates the calories.
        /// </summary>
        public uint Calories
        {
            get
            {
                return Drink.Calories + Side.Calories + Entree.Calories;
            }
        }
        /// <summary>
        /// Creates the ingredients list
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                return ingredients;
            }
        }
        /// <summary>
        /// Runs if combo is alled with no arguments.
        /// </summary>
        public CretaceousCombo() { }
        /// <summary>
        /// Constructor with one argument, entree.
        /// </summary>
        /// <param name="entree"></param>
        public CretaceousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }
        /// <summary>
        /// Prints out the name of the entree plus combo.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Entree} Combo";
        }
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.Add(Entree.Description);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }
    }
}
