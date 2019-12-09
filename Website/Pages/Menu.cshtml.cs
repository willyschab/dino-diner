using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;
namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu Menu { get; set; } = new Menu();
        [BindProperty]
        public IEnumerable<CretaceousCombo> Combos { get; set; }
        [BindProperty]
        public IEnumerable<Entree> Entrees { get; set; }
        [BindProperty]
        public IEnumerable<Side> Sides { get; set; }
        [BindProperty]
        public IEnumerable<Drink> Drinks { get; set; }
        [BindProperty]
        public string search { get; set; }
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();
        [BindProperty]
        public float? minimumPrice { get; set; }
        [BindProperty]
        public float? maximumPrice { get; set; }
        [BindProperty]
        public List<string> ingredients { get; set; } = new List<string>();

        public void OnGet()
        {
            Combos = Menu.AvailableCombos;
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
            Drinks = Menu.AvailableDrinks;
        }
        public void OnPost()
        {
            Combos = Menu.AvailableCombos;
            Entrees = Menu.AvailableEntrees;
            Sides = Menu.AvailableSides;
            Drinks = Menu.AvailableDrinks;
            if (search != null)
            {
                Combos = Combos.Where(combo => combo.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
                Entrees = Entrees.Where(entree => entree.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
                Sides = Sides.Where(side => side.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
                Drinks = Drinks.Where(drink => drink.Description.Contains(search, StringComparison.OrdinalIgnoreCase));
            }
            if (menuCategory.Count != 0)
            {
                Combos = Combos.Where(combo => menuCategory.Contains("Combo"));
                Entrees = Entrees.Where(entree => menuCategory.Contains("Entree"));
                Sides = Sides.Where(side => menuCategory.Contains("Side"));
                Drinks = Drinks.Where(drink => menuCategory.Contains("Drink"));
            }
            if(ingredients.Count != 0) {

                foreach(string c in ingredients)
                {
                    Combos = Combos.Where(combo => !combo.Ingredients.Contains(c));
                    Entrees = Entrees.Where(entree => !entree.Ingredients.Contains(c));
                    Sides = Sides.Where(side => !side.Ingredients.Contains(c));
                    Drinks = Drinks.Where(drink => !drink.Ingredients.Contains(c));
                }
            }
            if (minimumPrice != null)
            {
                Combos = Combos.Where(combo => combo.Price > minimumPrice || Math.Abs(combo.Price - (double)minimumPrice) < .0001);
                Entrees = Entrees.Where(entree => entree.Price >= minimumPrice || Math.Abs(entree.Price - (double)minimumPrice) < .0001);
                Sides = Sides.Where(side => side.Price >= minimumPrice || Math.Abs(side.Price - (double)minimumPrice) < .0001);
                Drinks = Drinks.Where(drink => drink.Price >= minimumPrice || Math.Abs(drink.Price - (double)minimumPrice) < .0001);
            }
            if (maximumPrice != null)
            {
                Combos = Combos.Where(combo => combo.Price <= maximumPrice || Math.Abs(combo.Price - (double)maximumPrice) < .0001);
                Entrees = Entrees.Where(entree => entree.Price <= maximumPrice || Math.Abs(entree.Price - (double)maximumPrice) < .0001);
                Sides = Sides.Where(side => side.Price <= maximumPrice || Math.Abs(side.Price - (double)maximumPrice) < .0001);
                Drinks = Drinks.Where(drink => drink.Price <= maximumPrice || Math.Abs(drink.Price - (double)maximumPrice) < .0001);
            }
        }
        public double comboSizePrice(string size, CretaceousCombo combo)
        {
            CretaceousCombo temp = combo;
            switch(size){
                case "small":
                    temp.Size = Size.Small;
                    return temp.Price;
                case "medium":
                    temp.Size = Size.Medium;
                    return temp.Price;
                case "large":
                    temp.Size = Size.Large;
                    return temp.Price;
                default:
                    return 0;
            }
        }
        public double sideSizePrice(string size, Side side)
        {
            Side temp = side;
            switch (size)
            {
                case "small":
                    temp.Size = Size.Small;
                    return temp.Price;
                case "medium":
                    temp.Size = Size.Medium;
                    return temp.Price;
                case "large":
                    temp.Size = Size.Large;
                    return temp.Price;
                default:
                    return 0;
            }
        }
        public double drinkSizePrice(string size, Drink drink)
        {
            Drink temp = drink;
            switch (size)
            {
                case "small":
                    temp.Size = Size.Small;
                    return temp.Price;
                case "medium":
                    temp.Size = Size.Medium;
                    return temp.Price;
                case "large":
                    temp.Size = Size.Large;
                    return temp.Price;
                default:
                    return 0;
            }
        }
    }
}