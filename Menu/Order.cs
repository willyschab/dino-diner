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
        List<IOrderItem> items = new List<IOrderItem>();
        double salesTaxRate = 0;
        /// <summary>
        /// Holds a collection of order items.
        /// </summary>
        public IOrderItem[] Items
        {
            get
            {
                return items.ToArray();
            }
        }
        public double SubTotalCost
        {
            get
            {
                double total = 0;
                foreach (var data in Items)
                {
                    total += data.Price;
                }
                if (total < 0)
                {
                    total *= -1;
                }
                return total;
            }
        }
        /// <summary>
        /// Gets and set sthe sales tax rate.
        /// </summary>
        public double SalesTaxRate
        {
            get { return SalesTaxRate; }
            protected set
            {
                if (value < 0) return;

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
        }

        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            NotifyAllPropertyChanged();

        }

        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyAllPropertyChanged();
            }
            return removed;
        }

        void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyAllPropertyChanged();
        }

        void NotifyAllPropertyChanged()
        {
            NotifyPropertyChanged("Items");
            NotifyPropertyChanged("SubtotalCost");
            NotifyPropertyChanged("SalesTaxCost");
            NotifyPropertyChanged("TotalCost");
        }
    }
}
