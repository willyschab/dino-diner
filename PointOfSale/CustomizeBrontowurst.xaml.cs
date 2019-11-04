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
    public partial class CustomizeBrontowurst : Page
    {
        private Brontowurst br;
        private bool combo = false;
        public CustomizeBrontowurst(Brontowurst br)
        {
            InitializeComponent();
            this.br = br;
        }
        public CustomizeBrontowurst(Brontowurst br, bool Combo)
        {
            InitializeComponent();
            combo = Combo;
            this.br = br;
        }

        private void OnHoldPeppers(object sender, RoutedEventArgs e)
        {
            br.HoldPeppers();
        }

        private void OnHoldOnion(object sender, RoutedEventArgs e)
        {
            br.HoldOnion();
        }

        private void OnHoldBun(object sender, RoutedEventArgs e)
        {
            br.HoldBun();
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            if (combo)
            {
                NavigationService.Navigate(new CustomizeCombo(br));
            }
            else
            {
                if (NavigationService.CanGoBack){
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
