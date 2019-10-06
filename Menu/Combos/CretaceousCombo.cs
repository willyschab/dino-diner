/*Author: Will Schabel
* Class: CretaceousCombo.cs
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class CretaceousCombo : IMenuItem
    {
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
        private Size size = Size.Small;
        /// <summary>
        /// Sets the size.
        /// </summary>
        public Size Size {
            get { return size; }
            set {
                this.size = value;
                this.Drink.Size = value;
                this.Side.Size = value;
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
        private CretaceousCombo() { }
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

    }
}
