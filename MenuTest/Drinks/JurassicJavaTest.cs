using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPriceAndCalories()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.Equal<double>(.59, coffee.Price);
            Assert.Equal<uint>(2, coffee.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterSettingSmall()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Medium;
            coffee.Size = Size.Small;
            Assert.Equal<double>(.59, coffee.Price);
            Assert.Equal<uint>(2, coffee.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterSettingMedium()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Medium;
            Assert.Equal<double>(.99, coffee.Price);
            Assert.Equal<uint>(4, coffee.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterSettingLarge()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.Size = Size.Large;
            Assert.Equal<double>(1.49, coffee.Price);
            Assert.Equal<uint>(8, coffee.Calories);
        }
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava coffee = new JurassicJava();
            Assert.False(coffee.Ice);
        }
        [Fact]
        public void ShouldBeAbleToAddIce()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.AddIce();
            Assert.True(coffee.Ice);
        }
        [Fact]
        public void ShouldBeAbleToLeaveRoomForCream()
        {
            JurassicJava coffee = new JurassicJava();
            coffee.LeaveRoomForCream();
            Assert.True(coffee.RoomForCream);
        }
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            JurassicJava coffee = new JurassicJava();
            List<string> Ingredients = coffee.Ingredients;
            Assert.Contains<string>("Water", Ingredients);
            Assert.Contains<string>("Coffee", Ingredients);
        }
    }
}
