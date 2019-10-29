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
    public partial class EntreeSelection : Page
    {
        public Entree Entree { get; set; }
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            this.Entree = entree;
        }
        public EntreeSelection()
        {
            InitializeComponent();
        }

        private void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Add(entree);
                this.Entree = entree;
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }

        private void OnAddPrehistoricPBJ(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                order.Add(pbj);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj));
            }
        }

        private void OnAddBrontowurst(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SelectEntree(new Brontowurst());
                
            }
        }

        private void OnAddNuggets(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SelectEntree(new DinoNuggets());
            }
        }

        private void OnAddSteakBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SelectEntree(new SteakosaurusBurger());
            }
        }

        private void OnAddWings(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SelectEntree(new PterodactylWings());
            }
        }

        private void OnAddVelociwrap(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SelectEntree(new VelociWrap());
            }
        }

        private void OnAddKingBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SelectEntree(new TRexKingBurger());
            }
        }
    }
}
