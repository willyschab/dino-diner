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
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }
        private void Customize(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());
        }

        private void CustomizeBronto(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Brontowurst br = new Brontowurst();
                order.Add(br);
                NavigationService.Navigate(new CustomizeCombo(br));
            }

        }

        private void CustomizeNuggets(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());

        }

        private void CustomizeSteakBurger(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());

        }

        private void CustomizeWings(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());

        }

        private void CustomizePBJ(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());

        }

        private void CustomizeWrap(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());

        }

        private void CustomizeKingBurger(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());

        }
    }
}
