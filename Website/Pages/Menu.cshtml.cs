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
        public List<CretaceousCombo> Combos { get; set; }
        [BindProperty]
        public List<Entree> Entrees { get; set; }
        [BindProperty]
        public List<Side> Sides { get; set; }
        [BindProperty]
        public List<Drink> Drinks { get; set; }
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
                Combos = ComboSearch(Combos, search);
                Entrees = EntreeSearch(Entrees, search);
                Sides = SideSearch(Sides, search);
                Drinks = DrinkSearch(Drinks, search);
            }
            if (menuCategory.Count != 0)
            {
                Entrees = new List<Entree>();
                Sides = new List<Side>();
                Drinks = new List<Drink>();
                Combos = new List<CretaceousCombo>();

                if (menuCategory.Contains("Combo"))
                {
                    Combos = Menu.AvailableCombos;
                }
                if (menuCategory.Contains("Entree"))
                {
                    Entrees = Menu.AvailableEntrees;
                }
                if (menuCategory.Contains("Side"))
                {
                    Sides = Menu.AvailableSides;
                }
                if (menuCategory.Contains("Drink"))
                {
                    Drinks = Menu.AvailableDrinks;
                }
            }
            if(ingredients.Count != 0) {

                foreach(string c in ingredients)
                {
                    foreach (CretaceousCombo combo in Combos.ToList())
                    {
                        if (combo.Ingredients.Contains(c))
                        {
                            Combos.Remove(combo);
                        }
                    }
                    foreach (Entree entree in Entrees.ToList())
                    {
                        if (entree.Ingredients.Contains(c))
                        {
                            Entrees.Remove(entree);
                        }
                    }
                    foreach (Side side in Sides.ToList())
                    {
                        if (side.Ingredients.Contains(c))
                        {
                            Sides.Remove(side);
                        }
                    }
                    foreach (Drink drink in Drinks.ToList())
                    {
                        if (drink.Ingredients.Contains(c))
                        {
                            Drinks.Remove(drink);
                        }
                    }
                }
            }
            if(minimumPrice != null)
            {
                List<Object> objCombo = Combos.Cast<Object>().ToList();
                objCombo = minimumPriceSort(objCombo, minimumPrice);
                List<CretaceousCombo> temp = objCombo.Cast<CretaceousCombo>().ToList();
                Combos = temp;

                List<Object> objEntree = Entrees.Cast<Object>().ToList();
                objEntree = minimumPriceSort(objEntree, minimumPrice);
                List<Entree> temp2 = objEntree.Cast<Entree>().ToList();
                Entrees = temp2;

                List<Object> objSide = Sides.Cast<Object>().ToList();
                objSide = minimumPriceSort(objSide, minimumPrice);
                List<Side> temp3 = objSide.Cast<Side>().ToList();
                Sides = temp3;

                List<Object> objDrink = Drinks.Cast<Object>().ToList();
                objDrink = minimumPriceSort(objDrink, minimumPrice);
                List<Drink> temp4 = objDrink.Cast<Drink>().ToList();
                Drinks = temp4;
            }
            if (maximumPrice != null)
            {
                List<Object> objCombo = Combos.Cast<Object>().ToList();
                objCombo = maximumPriceSort(objCombo, maximumPrice);
                List<CretaceousCombo> temp = objCombo.Cast<CretaceousCombo>().ToList();
                Combos = temp;

                List<Object> objEntree = Entrees.Cast<Object>().ToList();
                objEntree = maximumPriceSort(objEntree, maximumPrice);
                List<Entree> temp2 = objEntree.Cast<Entree>().ToList();
                Entrees = temp2;

                List<Object> objSide = Sides.Cast<Object>().ToList();
                objSide = maximumPriceSort(objSide, maximumPrice);
                List<Side> temp3 = objSide.Cast<Side>().ToList();
                Sides = temp3;

                List<Object> objDrink = Drinks.Cast<Object>().ToList();
                objDrink = maximumPriceSort(objDrink, maximumPrice);
                List<Drink> temp4 = objDrink.Cast<Drink>().ToList();
                Drinks = temp4;
            }
        }

        public static List<Object> minimumPriceSort(List<Object> input, float? minimumPrice)
        {
            if(input.Count == 0)
            {
                return new List<Object>();
            }
            CretaceousCombo checkCombo = input[0] as CretaceousCombo;
            Entree checkEntree = input[0] as Entree;
            Side checkSide = input[0] as Side;
            Drink checkDrink = input[0] as Drink;

            if(checkCombo != null)
            {
                List<CretaceousCombo> temp = input.Cast<CretaceousCombo>().ToList();
                foreach(CretaceousCombo combo in temp.ToList())
                {
                    if(combo.Price <= minimumPrice)
                    {
                        temp.Remove(combo);
                    }
                }
                List<Object> result = temp.Cast<Object>().ToList();
                return result;
            }
            else if (checkEntree != null)
            {
                List<Entree> temp = input.Cast<Entree>().ToList();
                foreach (Entree entree in temp.ToList())
                {
                    if (entree.Price <= minimumPrice)
                    {
                        temp.Remove(entree);
                    }
                }
                List<Object> result = temp.Cast<Object>().ToList();
                return result;
            }
            else if (checkSide != null)
            {
                List<Side> temp = input.Cast<Side>().ToList();
                foreach (Side side in temp.ToList())
                {
                    if (side.Price <= minimumPrice)
                    {
                        temp.Remove(side);
                    }
                }
                List<Object> result = temp.Cast<Object>().ToList();
                return result;
            }
            else if (checkDrink != null)
            {
                List<Drink> temp = input.Cast<Drink>().ToList();
                foreach (Drink drink in temp.ToList())
                {
                    if (drink.Price <= minimumPrice)
                    {
                        temp.Remove(drink);
                    }
                }
                List<Object> result = temp.Cast<Object>().ToList();
                return result;
            }
            else
            {
                return new List<Object>();
            }
        }

        public static List<Object> maximumPriceSort(List<Object> input, float? maximumPrice)
        {
            if (input.Count == 0)
            {
                return new List<Object>();
            }
            CretaceousCombo checkCombo = input[0] as CretaceousCombo;
            Entree checkEntree = input[0] as Entree;
            Side checkSide = input[0] as Side;
            Drink checkDrink = input[0] as Drink;

            if (checkCombo != null)
            {
                List<CretaceousCombo> temp = input.Cast<CretaceousCombo>().ToList();
                foreach (CretaceousCombo combo in temp.ToList())
                {
                    if (combo.Price <= maximumPrice)
                    {
                        temp.Remove(combo);
                    }
                }
                List<Object> result = temp.Cast<Object>().ToList();
                return result;
            }
            else if (checkEntree != null)
            {
                List<Entree> temp = input.Cast<Entree>().ToList();
                foreach (Entree entree in temp.ToList())
                {
                    if (entree.Price <= maximumPrice)
                    {
                        temp.Remove(entree);
                    }
                }
                List<Object> result = temp.Cast<Object>().ToList();
                return result;
            }
            else if (checkSide != null)
            {
                List<Side> temp = input.Cast<Side>().ToList();
                foreach (Side side in temp.ToList())
                {
                    if (side.Price <= maximumPrice)
                    {
                        temp.Remove(side);
                    }
                }
                List<Object> result = temp.Cast<Object>().ToList();
                return result;
            }
            else if (checkDrink != null)
            {
                List<Drink> temp = input.Cast<Drink>().ToList();
                foreach (Drink drink in temp.ToList())
                {
                    if (drink.Price <= maximumPrice)
                    {
                        temp.Remove(drink);
                    }
                }
                List<Object> result = temp.Cast<Object>().ToList();
                return result;
            }
            else
            {
                return new List<Object>();
            }
        }

        public static List<Entree> EntreeSearch(List<Entree> Entrees, string term)
        {
            List<Entree> results = new List<Entree>();
            foreach (Entree entree in Entrees)
            {
                if (entree.Description.Contains(term, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(entree);
                }
            }
            return results;
        }
        public static List<CretaceousCombo> ComboSearch(List<CretaceousCombo> Combos, string term)
        {
            List<CretaceousCombo> results = new List<CretaceousCombo>();
            foreach (CretaceousCombo combo in Combos)
            {
                if (combo.Description.Contains(term, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(combo);
                }
            }
            return results;
        }
        public static List<Side> SideSearch(List<Side> Sides, string term)
        {
            List<Side> results = new List<Side>();
            foreach (Side side in Sides)
            {
                if (side.Description.Contains(term, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(side);
                }
            }
            return results;
        }
        public static List<Drink> DrinkSearch(List<Drink> Drinks, string term)
        {
            List<Drink> results = new List<Drink>();
            foreach (Drink drink in Drinks)
            {
                if (drink.Description.Contains(term, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(drink);
                }
            }
            return results;
        }
    }
}