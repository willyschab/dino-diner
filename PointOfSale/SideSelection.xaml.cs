using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private void SelectSide(Side side)
        {
            if(DataContext is Order order)
            {
                order.Items.Add(side);
                this.Side = side;
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (DataContext is Order order)
            {
                if(Side != null)
                {
                this.Side.Size = size;
                }
            }
        }

        protected void OnSelectFryceritops(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                SelectSide(new Fryceritops());
            }
        }

        protected void OnSelectLarge(object sender, ExecutedRoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }
        protected void OnSelectMediume(object sender, ExecutedRoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }
        protected void OnSelectSmall(object sender, ExecutedRoutedEventArgs args)
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }
    }
}
