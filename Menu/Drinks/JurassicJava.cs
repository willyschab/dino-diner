using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu.Drinks
{
    public class JurassicJava : Drink
    {
        private bool _roomForCream = false;
        private bool _decaf = false;
        private Size size;
        /// <summary>
        /// Sets our roomforcream property to it's default value, and allows it to be set.
        /// </summary>
        public bool RoomForCream
        {
            get { return _roomForCream; }
            set { _roomForCream = value; }
        }
        /// <summary>
        /// Sets the default value for decaf and allows it to be set.
        /// </summary>
        public bool Decaf
        {
            get { return _decaf;  }
            set { _decaf = value; }
        }
        /// <summary>
        /// Sets the default price, calories, ingredients, and ice.
        /// </summary>
         public JurassicJava()
        {
            this.Price = .59;
            this.Calories = 2;
            this.Ingredients = new List<string>() { "Water", "Coffee" };
            this.Ice = false;
        }
        /// <summary>
        /// Allows the RoomForCream variable to be switched to true.
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }
        /// <summary>
        /// Allows the addition of ice.
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
        }
        /// <summary>
        /// Changes the price and calories when size is changed.
        /// </summary>
        public Size Size
        {
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Medium:
                        this.Price = .99;
                        this.Calories = 4;
                        break;
                    case Size.Large:
                        this.Price = 1.49;
                        this.Calories = 8;
                        break;
                    case Size.Small:
                        this.Price = .59;
                        this.Calories = 2;
                        break;
                }
            }
            get
            {
                return size;
            }
        }
    }
}
