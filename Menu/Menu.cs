/*Author: Will Schabel
* Class: Menu.cs
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        public List<object> AvailableMenuItems
        {
            get
            {
                return new List<Object>()
                {
                    new CretaceousCombo(),
                    new JurassicJava(),
                    new Sodasaurus(),
                    new Tyrannotea(),
                    new Water(),
                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new PterodactylWings(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap(),
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()
                };
            }
            set
            {
                AvailableMenuItems = value;
            }
        }
        public List<Entree> AvailableEntrees
        {
            get
            {
                return new List<Entree>()
                {
                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new PterodactylWings(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap(),
                };
            }
            set
            {
                AvailableEntrees = value;
            }
        }
        public List<Side> AvailableSides
        {
            get
            {
                Fryceritops ft = new Fryceritops();
                MeteorMacAndCheese mmc = new MeteorMacAndCheese();
                MezzorellaSticks ms = new MezzorellaSticks();
                Triceritots tt = new Triceritots();


                List<Side> sides = new List<Side>()
                {
                    ft, ms, tt
                };
                return sides;

            }
            set
            {
                AvailableSides = value;
            }
        }
        public List<Drink> AvailableDrinks
        {
            get
            {
                {
                    JurassicJava jv = new JurassicJava();
                    Sodasaurus sd = new Sodasaurus();
                    Tyrannotea tt = new Tyrannotea();
                    Water w = new Water();
                    List<Drink> drinks = new List<Drink>()
                    {
                        jv, sd, tt, w
                    };
                    return drinks;
                };
            }
            set
            {
                AvailableDrinks = value;
            }
        }
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                Brontowurst br = new Brontowurst();
                DinoNuggets dn = new DinoNuggets();
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                PterodactylWings pw = new PterodactylWings();
                SteakosaurusBurger sb = new SteakosaurusBurger();
                TRexKingBurger tkb = new TRexKingBurger();
                VelociWrap vw = new VelociWrap();

                CretaceousCombo brCombo = new CretaceousCombo(br);
                CretaceousCombo dnCombo = new CretaceousCombo(dn);
                CretaceousCombo pbjCombo = new CretaceousCombo(pbj);
                CretaceousCombo pwCombo = new CretaceousCombo(pw);
                CretaceousCombo sbCombo = new CretaceousCombo(sb);
                CretaceousCombo tkbCombo = new CretaceousCombo(tkb);
                CretaceousCombo vwCombo = new CretaceousCombo(vw);


                List<CretaceousCombo> combos = new List<CretaceousCombo>()
                {
                    brCombo,
                    dnCombo,
                    pbjCombo,
                    pwCombo,
                    sbCombo,
                    tkbCombo,
                    vwCombo
                };
                return combos;
            }
            set
            {
                AvailableCombos = value;
            }
        }
        public override string ToString()
        {
            string conc = "";
            foreach(object c in AvailableMenuItems)
            {
                Side side = c as Side;
                Entree entree = c as Entree;
                Drink drink = c as Drink;
                CretaceousCombo combo = c as CretaceousCombo;
                conc += $"{c}\n";
            }
            return conc;
        }

        public HashSet<string> PossibleIngredients
        {
            get
            {
                HashSet<string> ingredients = new HashSet<string>();
                ingredients.UnionWith(new Brontowurst().Ingredients);
                ingredients.UnionWith(new DinoNuggets().Ingredients);
                ingredients.UnionWith(new PrehistoricPBJ().Ingredients);
                ingredients.UnionWith(new PterodactylWings().Ingredients);
                ingredients.UnionWith(new SteakosaurusBurger().Ingredients);
                ingredients.UnionWith(new TRexKingBurger().Ingredients);
                ingredients.UnionWith(new VelociWrap().Ingredients);
                ingredients.UnionWith(new Fryceritops().Ingredients);
                ingredients.UnionWith(new MeteorMacAndCheese().Ingredients);
                ingredients.UnionWith(new MezzorellaSticks().Ingredients);
                ingredients.UnionWith(new Triceritots().Ingredients);
                ingredients.UnionWith(new JurassicJava().Ingredients);
                ingredients.UnionWith(new Sodasaurus().Ingredients);
                ingredients.UnionWith(new Tyrannotea().Ingredients);
                ingredients.UnionWith(new Water().Ingredients);

                Brontowurst br = new Brontowurst();
                DinoNuggets dn = new DinoNuggets();
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                PterodactylWings pw = new PterodactylWings();
                SteakosaurusBurger sb = new SteakosaurusBurger();
                TRexKingBurger tkb = new TRexKingBurger();
                VelociWrap vw = new VelociWrap();

                CretaceousCombo brCombo = new CretaceousCombo(br);
                CretaceousCombo dnCombo = new CretaceousCombo(dn);
                CretaceousCombo pbjCombo = new CretaceousCombo(pbj);
                CretaceousCombo pwCombo = new CretaceousCombo(pw);
                CretaceousCombo sbCombo = new CretaceousCombo(sb);
                CretaceousCombo tkbCombo = new CretaceousCombo(tkb);
                CretaceousCombo vwCombo = new CretaceousCombo(vw);

                ingredients.UnionWith(brCombo.Ingredients);
                ingredients.UnionWith(dnCombo.Ingredients);
                ingredients.UnionWith(pbjCombo.Ingredients);
                ingredients.UnionWith(pwCombo.Ingredients);
                ingredients.UnionWith(sbCombo.Ingredients);
                ingredients.UnionWith(tkbCombo.Ingredients);
                ingredients.UnionWith(vwCombo.Ingredients);

                return ingredients;
            }
            set
            {
                PossibleIngredients = value;
            }
        }

    }
}
