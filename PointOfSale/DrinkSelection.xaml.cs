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
    public partial class DrinkSelection : Page
    {
        private bool combo = false;
        public Drink Drink { get; set; }
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            this.Drink = drink;
        }
        public DrinkSelection()
        {
            InitializeComponent();
        }
        public DrinkSelection(bool Combo)
        {
            InitializeComponent();
            combo = Combo;
        }
        private void SelectDrink(Drink drink)
        {
            if (DataContext is Order order)
            {
                order.Add(drink);
                this.Drink = drink;
            }
        }
        private void SodaFlavorsView(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection(Drink));
        }

        private void SodaSelect(object sender, RoutedEventArgs e)
        {
            FlavorButton.Opacity = 100;
            FlavorButton.IsEnabled = true;
            LemonButton.Opacity = 0;
            LemonButton.IsEnabled = false;
            SweetButton.Opacity = 0;
            SweetButton.IsEnabled = false;
            DecafButton.Opacity = 0;
            DecafButton.IsEnabled = false;
            if (DataContext is Order order)
            {
                SelectDrink(new Sodasaurus());
            }
        }

        private void TeaSelect(object sender, RoutedEventArgs e)
        {
            LemonButton.Opacity = 100;
            LemonButton.IsEnabled = true;
            SweetButton.Opacity = 100;
            SweetButton.IsEnabled = true;
            DecafButton.Opacity = 0;
            DecafButton.IsEnabled = false;
            FlavorButton.Opacity = 0;
            FlavorButton.IsEnabled = false;
            if (DataContext is Order order)
            {
                SelectDrink(new Tyrannotea());
            }
        }

        private void JavaSelect(object sender, RoutedEventArgs e)
        {
            DecafButton.Opacity = 100;
            DecafButton.IsEnabled = true;
            LemonButton.Opacity = 0;
            LemonButton.IsEnabled = false;
            SweetButton.Opacity = 0;
            SweetButton.IsEnabled = false;
            FlavorButton.Opacity = 0;
            FlavorButton.IsEnabled = false;
            if (DataContext is Order order)
            {
                SelectDrink(new JurassicJava());
            }
        }

        private void WaterSelect(object sender, RoutedEventArgs e)
        {
            LemonButton.Opacity = 100;
            LemonButton.IsEnabled = true;
            DecafButton.Opacity = 0;
            DecafButton.IsEnabled = false;
            FlavorButton.Opacity = 0;
            FlavorButton.IsEnabled = false;
            SweetButton.Opacity = 0;
            SweetButton.IsEnabled = false;
            if (DataContext is Order order)
            {
                SelectDrink(new Water());
            }
        }
        private void SelectSize(DinoDiner.Menu.Size size)
        {
            if (DataContext is Order order)
            {
                if (Drink != null)
                {
                    this.Drink.Size = size;
                }
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

        private void OnDecaf(object sender, RoutedEventArgs e)
        {
            JurassicJava temp = new JurassicJava();
            temp = (JurassicJava)Drink;
            temp.Decaf = true;
        }

        private void OnSweet(object sender, RoutedEventArgs e)
        {
            Tyrannotea temp = new Tyrannotea();
            temp = (Tyrannotea)Drink;
            temp.Sweet = true;
        }

        private void OnLemon(object sender, RoutedEventArgs e)
        {
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            if (combo)
            {
                NavigationService.Navigate(new CustomizeCombo());
            }
            else
            {
            NavigationService.Navigate(new MenuCategorySelection());
            }
        }
    }
}
