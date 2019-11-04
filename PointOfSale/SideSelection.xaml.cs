using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    public partial class SideSelection : Page
    {
        private bool combo = false;
        public Side Side { get; set; }
        public SideSelection()
        {
            InitializeComponent();
        }
        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }
        public SideSelection(bool Combo)
        {
            InitializeComponent();
            combo = Combo;
        }

        private void SelectSide(Side side)
        {
            if(DataContext is Order order)
            {
                order.Add(side);
                this.Side = side;
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (DataContext is Order order)
            {
                if(Side != null)
                {
                    Side.Size = size;                
                }
            }
            if (combo)
            {
                NavigationService.Navigate(new CustomizeCombo());
            }
            else
            {
            NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        protected void OnSelectLarge(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }
        protected void OnSelectMedium(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }
        protected void OnSelectSmall(object sender, RoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        protected void OnSelectFryceritops(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SelectSide(new Fryceritops());
            }
        }

        private void OnSelecttriceritops(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SelectSide(new Triceritots());
            }
        }

        private void OnSelectMacCheese(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SelectSide(new MeteorMacAndCheese());
            }
        }

        private void OnSelectMezzorellaSticks(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SelectSide(new MezzorellaSticks());
            }
        }
    }
}
