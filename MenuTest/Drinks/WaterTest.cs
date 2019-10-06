using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPriceAndCalories()
        {
            Water water = new Water();
            Assert.Equal<double>(.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterSettingSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<double>(.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterSettingMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterSettingLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }
        [Fact]
        public void ShouldBeAbleToHoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }
        [Fact]
        public void ShouldBeAbleToAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Water water = new Water();
            List<string> Ingredients = water.Ingredients;
            Assert.Contains<string>("Water", Ingredients);
        }
    }
}
