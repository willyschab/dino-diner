using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Menu
    {
        public List<object> AvailableMenuItems { get; }
        public List<Entree> AvailableEntrees { get; }
        public List<Side> AvailableSides { get; }
        public List<Drink> AvailableDrinks { get; }
        public List<CretaceousCombo> AvailableCombos { get; }

        public override string ToString()
        {
            string conc = "";
            foreach(object c in AvailableMenuItems)
            {
                conc += $"{c}\n";
            }
            return conc;
        }

    }
}
