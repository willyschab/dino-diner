/*Author: Will Schabel
* Class: DinoNuggets.cs
*/
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class DinoNuggets : Entree, INotifyPropertyChanged
    {
        public int  NuggetCount { get; set; }

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
        /// sets up the ingredients.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                for (int i = 0; i < NuggetCount; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }
        /// <summary>
        /// Sets the price, number of nuggets being purchased, and calories.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.NuggetCount = 6;
            this.Calories = 59 * 6;
        }
        /// <summary>
        /// This method allows the user to add more nuggets to their order.
        /// </summary>
        public void AddNugget()
        {
            this.NuggetCount++;
            this.Price += .25;
            this.Calories += 59;
            NotifyOfPropertyChange("Special");
            NotifyOfPropertyChange("Ingredients");
        }
        /// <summary>
        /// Prints out the correct name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
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
                if (NuggetCount > 6) special.Add($"{NuggetCount - 6} Extra Nugget(s)");
                return special.ToArray();
            }
        }

    }
}
