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
    public partial class CustomizeDinoNuggets : Page
    {
        private DinoNuggets dn;
        private bool combo = false;
        public CustomizeDinoNuggets(DinoNuggets dn)
        {
            InitializeComponent();
            this.dn = dn;
        }
        public CustomizeDinoNuggets(DinoNuggets dn, bool Combo)
        {
            InitializeComponent();
            combo = Combo;
            this.dn = dn;
        }

        private void OnAddNugget(object sender, RoutedEventArgs e)
        {
            dn.AddNugget();
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            if (combo)
            {
                NavigationService.Navigate(new CustomizeCombo(dn));
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
