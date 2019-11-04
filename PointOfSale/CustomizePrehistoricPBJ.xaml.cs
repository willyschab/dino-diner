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
    public partial class CustomizePrehistoricPBJ : Page
    {
        private PrehistoricPBJ pbj;
        private bool combo = false;
        public CretaceousCombo CretaceousCombo { get; set; }
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }
        public CustomizePrehistoricPBJ(PrehistoricPBJ pbj, CretaceousCombo cretaceousCombo)
        {
            InitializeComponent();
            combo = true;
            this.pbj = pbj;
            CretaceousCombo = cretaceousCombo;
        }

        private void OnHoldPeanutButter(object sender, RoutedEventArgs e)
        {
            pbj.HoldPeanutButter();
        }

        private void OnHoldJelly(object sender, RoutedEventArgs e)
        {
            pbj.HoldJelly();
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
