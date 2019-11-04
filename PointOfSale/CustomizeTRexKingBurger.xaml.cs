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
    public partial class CustomizeTRexKingBurger : Page
    {
        private TRexKingBurger kb = new TRexKingBurger();
        private bool combo = false;
        public CretaceousCombo CretaceousCombo { get; set; }
        public CustomizeTRexKingBurger(TRexKingBurger kb)
        {
            InitializeComponent();
            this.kb = kb;
        }
        public CustomizeTRexKingBurger(TRexKingBurger kb, CretaceousCombo cretaceousCombo)
        {
            InitializeComponent();
            combo = true;
            this.kb = kb;
            CretaceousCombo = cretaceousCombo;
        }

        private void OnHoldPickle(object sender, RoutedEventArgs e)
        {
            kb.HoldPickle();
        }

        private void OnHoldMustard(object sender, RoutedEventArgs e)
        {
            kb.HoldMustard();
        }

        private void OnHoldKetchup(object sender, RoutedEventArgs e)
        {
            kb.HoldKetchup();
        }
        private void OnHoldbun(object sender, RoutedEventArgs e)
        {
            kb.HoldBun();
        }
        private void OnHoldOnion(object sender, RoutedEventArgs e)
        {
            kb.HoldOnion();
        }
        private void OnHoldMayo(object sender, RoutedEventArgs e)
        {
            kb.HoldMayo();
        }
        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            kb.HoldLettuce();
        }
        private void OnHoldTomato(object sender, RoutedEventArgs e)
        {
            kb.HoldTomato();
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            if (combo)
            {
                NavigationService.Navigate(new CustomizeCombo(CretaceousCombo));
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
