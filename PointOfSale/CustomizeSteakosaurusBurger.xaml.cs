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
    /// Interaction logic for CustomizePrehistoricPBJ.xaml
    /// </summary>
    public partial class CustomizeSteakosaurusBurger : Page
    {
        private SteakosaurusBurger sb = new SteakosaurusBurger();
        private bool combo = false;
        public CustomizeSteakosaurusBurger(SteakosaurusBurger sb)
        {
            InitializeComponent();
            this.sb = sb;
        }
        public CustomizeSteakosaurusBurger(SteakosaurusBurger sb, bool Combo)
        {
            InitializeComponent();
            combo = Combo;
            this.sb = sb;
        }

        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            sb.HoldPickle();
        }

        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            sb.HoldMustard();
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            sb.HoldKetchup();
        }
        private void OnHoldbun(object sender, RoutedEventArgs e)
        {
            sb.HoldBun();
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            if (combo)
            {
                NavigationService.Navigate(new CustomizeCombo(sb));
            }
            else
            {
                if (NavigationService.CanGoBack)
                {
                    NavigationService.GoBack();
                }
                else
                {
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }
    }
}
