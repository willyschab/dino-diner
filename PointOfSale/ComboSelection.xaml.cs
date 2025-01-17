﻿using System;
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
    public partial class ComboSelection : Page
    {
        public Entree Entree { get; set; }
        public CretaceousCombo CretaceousCombo { get; set; }
        public ComboSelection(Entree entree)
        {
            InitializeComponent();
            this.Entree = entree;
        }
        public ComboSelection()
        {
            InitializeComponent();
        }
        private void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo = new CretaceousCombo(entree);
                order.Add(CretaceousCombo);
            }
        }

        private void CustomizeBronto(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                Brontowurst br = new Brontowurst();
                SelectEntree(br);
                NavigationService.Navigate(new CustomizeBrontowurst(br, CretaceousCombo));
            }

        }

        private void CustomizeNuggets(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                DinoNuggets dn = new DinoNuggets();
                SelectEntree(dn);
                NavigationService.Navigate(new CustomizeDinoNuggets(dn, CretaceousCombo));
            }

        }

        private void CustomizeSteakBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SteakosaurusBurger sb = new SteakosaurusBurger();
                SelectEntree(sb);
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(sb, CretaceousCombo));
            }
        }

        private void CustomizeWings(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                SelectEntree(new PterodactylWings());
            }
        }

        private void CustomizePBJ(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                SelectEntree(pbj);
                NavigationService.Navigate(new CustomizePrehistoricPBJ(pbj, CretaceousCombo));
            }
        }

        private void CustomizeWrap(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                VelociWrap vw = new VelociWrap();
                SelectEntree(vw);
                NavigationService.Navigate(new CustomizeVelociWrap(vw, CretaceousCombo));
            }
        }

        private void CustomizeKingBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                TRexKingBurger kb = new TRexKingBurger();
                SelectEntree(kb);
                NavigationService.Navigate(new CustomizeTRexKingBurger(kb, CretaceousCombo));
            }
        }
    }
}
