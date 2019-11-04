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
    public partial class CustomizeCombo : Page
    {
        private bool Combo = true;
        public Side Side { get; set; }
        public Drink Drink { get; set; }
        public CretaceousCombo CretaceousCombo { get; set; }
        public CustomizeCombo(CretaceousCombo CretaceousCombo)
        {
            InitializeComponent();
            this.CretaceousCombo = CretaceousCombo;
        }
        public CustomizeCombo()
        {
            InitializeComponent();
        }
        private void SelectDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection(Combo));
        }

        private void SelectSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection(Combo));
        }
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (DataContext is Order order)
            {
                if (CretaceousCombo != null)
                {
                    CretaceousCombo.Size = size;
                }
            }
        }
        protected void OnSelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }
        protected void OnSelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }
        protected void OnSelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }
    }
}
