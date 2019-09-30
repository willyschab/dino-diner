using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPriceAndCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(.99, tea.Price);
            Assert.Equal<uint>(8, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(.99, tea.Price);
            Assert.Equal<uint>(8, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
            Assert.Equal<uint>(16, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
            Assert.Equal<uint>(32, tea.Calories);
        }
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }
        [Fact]
        public void ShouldBeAbleToHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }
        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }
        [Fact]
        public void ShouldBeAbleToAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForSweetSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.SwitchSugar();
            Assert.Equal<uint>(16, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForSweetMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.SwitchSugar();
            Assert.Equal<uint>(32, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForSweetLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.SwitchSugar();
            Assert.Equal<uint>(64, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForSmallAfterSwitchingSweetFalse()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            tea.SwitchSugar();
            tea.SwitchSugar();
            Assert.Equal<uint>(8, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForMediumAfterSwitchingSweetFalse()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.SwitchSugar();
            tea.SwitchSugar();
            Assert.Equal<uint>(16, tea.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectCaloriesForLargeAfterSwitchingSweetFalse()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.SwitchSugar();
            tea.SwitchSugar();
            Assert.Equal<uint>(32, tea.Calories);
        }
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            List<string> Ingredients = tea.Ingredients;
            Assert.Contains<string>("Water", Ingredients);
            Assert.Contains<string>("Tea", Ingredients);
        }
    }
}
