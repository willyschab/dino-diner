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
    public partial class CustomizeVelociWrap : Page
    {
        private VelociWrap vw;
        private bool combo = false;
        public CretaceousCombo CretaceousCombo { get; set; }
        public CustomizeVelociWrap(VelociWrap vw)
        {
            InitializeComponent();
            this.vw = vw;
        }
        public CustomizeVelociWrap(VelociWrap vw, CretaceousCombo cretaceousCombo)
        {
            InitializeComponent();
            combo = true;
            this.vw = vw;
            CretaceousCombo = cretaceousCombo;
        }

        private void OnHoldDressing(object sender, RoutedEventArgs e)
        {
            vw.HoldDressing();
        }

        private void OnHoldCheese(object sender, RoutedEventArgs e)
        {
            vw.HoldCheese();
        }

        private void OnHoldLettuce(object sender, RoutedEventArgs e)
        {
            vw.HoldLettuce();
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
