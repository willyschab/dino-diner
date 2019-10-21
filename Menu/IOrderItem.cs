/*Author: Will Schabel
* Class: IOrderItem.cs
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem
    {
        double Price { get; }
        uint Calories { get; }
        List<string> Ingredients { get; }
        string[] Special { get;  }
        string Description { get; }

    }
}
