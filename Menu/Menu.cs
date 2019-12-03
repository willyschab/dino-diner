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

                Fryceritops ft2 = new Fryceritops();
                MeteorMacAndCheese mmc2 = new MeteorMacAndCheese();
                MezzorellaSticks ms2 = new MezzorellaSticks();
                Triceritots tt2 = new Triceritots();
                ft2.Size = Size.Medium;
                mmc2.Size = Size.Medium;
                ms2.Size = Size.Medium;
                tt2.Size = Size.Medium;

                Fryceritops ft3 = new Fryceritops();
                MeteorMacAndCheese mmc3 = new MeteorMacAndCheese();
                MezzorellaSticks ms3 = new MezzorellaSticks();
                Triceritots tt3 = new Triceritots();
                ft3.Size = Size.Large;
                mmc3.Size = Size.Large;
                ms3.Size = Size.Large;
                tt3.Size = Size.Large;

                List<Side> sides = new List<Side>()
                {
                    ft, ft2, ft3, mmc, mmc2, mmc3, ms, ms2, ms3, tt, tt2, tt3
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

                    JurassicJava jv2 = new JurassicJava();
                    Sodasaurus sd2 = new Sodasaurus();
                    Tyrannotea tt2 = new Tyrannotea();
                    Water w2 = new Water();
                    jv2.Size = Size.Medium;
                    sd2.Size = Size.Medium;
                    tt2.Size = Size.Medium;
                    w2.Size = Size.Medium;

                    JurassicJava jv3 = new JurassicJava();
                    Sodasaurus sd3 = new Sodasaurus();
                    Tyrannotea tt3 = new Tyrannotea();
                    Water w3 = new Water();
                    jv3.Size = Size.Large;
                    sd3.Size = Size.Large;
                    tt3.Size = Size.Large;
                    w3.Size = Size.Large;
                    List<Drink> drinks = new List<Drink>()
                    {
                        jv, jv2, jv3, sd, sd2, sd3, tt, tt2, tt3, w, w2, w3
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
