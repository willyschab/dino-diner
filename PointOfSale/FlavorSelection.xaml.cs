using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        public Drink Drink { get; set; }
        public FlavorSelection(Drink drink)
        {
            InitializeComponent();
            Drink = drink;
        }

        private void SelectFlavor(DinoDiner.Menu.SodasaurusFlavor Flavor)
        {
            if (DataContext is Order order)
            {
                if (Drink != null)
                {
                    this.Drink.SodasaurusFlavor = Flavor;
                }
            }
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void OnCherry(object sender, RoutedEventArgs e)
        {
            SelectFlavor(DinoDiner.Menu.SodasaurusFlavor.Cherry);
        }

        private void OnChocolate(object sender, RoutedEventArgs e)
        {
            SelectFlavor(DinoDiner.Menu.SodasaurusFlavor.Chocolate);
        }

        private void OnCola(object sender, RoutedEventArgs e)
        {
            SelectFlavor(DinoDiner.Menu.SodasaurusFlavor.Cola);
        }

        private void OnOrange(object sender, RoutedEventArgs e)
        {
            SelectFlavor(DinoDiner.Menu.SodasaurusFlavor.Orange);
        }

        private void OnRootBeer(object sender, RoutedEventArgs e)
        {
            SelectFlavor(DinoDiner.Menu.SodasaurusFlavor.RootBeer);
        }

        private void OnVanilla(object sender, RoutedEventArgs e)
        {
            SelectFlavor(DinoDiner.Menu.SodasaurusFlavor.Vanilla);
        }

        private void OnLime(object sender, RoutedEventArgs e)
        {
            SelectFlavor(DinoDiner.Menu.SodasaurusFlavor.Lime);
        }
    }
}
