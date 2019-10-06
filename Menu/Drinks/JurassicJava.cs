﻿/*Author: Will Schabel
* Class: JurassicJava.cs
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink
    {
        private bool _roomForCream = false;
        private bool _decaf = false;
        private Size size;
        private string sizeString;
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
            this.Ice = false;
        }
        /// <summary>
        /// Builds the ingredients and makes them immutable.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Coffee" };
                return ingredients;
            }
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
                        this.sizeString = "Medium";
                        break;
                    case Size.Large:
                        this.Price = 1.49;
                        this.Calories = 8;
                        this.sizeString = "Large";
                        break;
                    case Size.Small:
                        this.Price = .59;
                        this.Calories = 2;
                        this.sizeString = "Small";
                        break;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// Prints out the correct name for the drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return  sizeString + " Decaf " + "Jurassic Java";
            }
            else
            {
                return sizeString + " Jurassic Java";

            }
        }
    }
}
