/*Author: Will Schabel
* Class: Order.cs
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private double temp;
        /// <summary>
        /// Holds a collection of order items.
        /// </summary>

        public ObservableCollection<IOrderItem> Items {get; protected set;}
        public double SubTotalCost
        {
            get
            {
                foreach(var data in Items)
                {
                    temp += data.Price;
                }
                if(temp < 0)
                {
                    temp *= -1;
                }
                return temp;
            }
        }
        /// <summary>
        /// Gets and set sthe sales tax rate.
        /// </summary>
        public double SalesTaxRate {
            get { return SalesTaxRate; }
            protected set
            {
                if (value < 0) return;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));

            }
        }
        /// <summary>
        /// Gets the sales tax cost.
        /// </summary>
        public double SalesTaxCost { get; }
        /// <summary>
        /// Gets the total cost.
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubTotalCost + SalesTaxCost;
            }
        }
        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
            Items.CollectionChanged += OnCollectionChanged;
        }

        private void OnCollectionChanged(object sender, EventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }

    }
}
