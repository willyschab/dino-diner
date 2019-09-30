using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu
{
    public class CretaciousCombo
    {
        public Entree Entree { get; set; }
        public Drink Drink { get; set; }
        public Side Side { get; set; }

        private Size size = Size.Small;
        public Size Size {
            get { return size; }
            set {
                this.size = value;
                this.Drink.Size = value;
                this.Side.Size = value;
            }
        }

        public double Price
        {
            get
            {
                return Drink.Price + Side.Price + Entree.Price - 0.25;
            }
        }
        public override string ToString()
        {
            return "";
        }
        public uint Calories
        {
            get
            {
                return Drink.Calories + Side.Calories + Entree.Calories;
            }
        }
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

        private CretaciousCombo() { }
        public CretaciousCombo(Entree entree)
        {
            Entree = entree;
            Side = new Fryceritops();
            Drink = new Sodasaurus();
        }

    }
}
