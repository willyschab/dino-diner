/*Author: Will Schabel
* Class: Order.cs
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    public class Order
    {
        private double temp;
        /// <summary>
        /// Holds a collection of order items.
        /// </summary>

        public ObservableCollection<IOrderItem> Items {get; set;}
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
        public double SalesTaxRate { get; protected set; }
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

    }
}
