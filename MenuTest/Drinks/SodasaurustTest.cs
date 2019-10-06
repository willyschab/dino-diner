using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        
        [Fact]
        public void ShouldHaveCorrectDefaultPriceandCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
            Assert.Equal<uint>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        [Fact]
        public void ShouldBeAbleToHoldIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
            Assert.Equal<uint>(112, soda.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
            Assert.Equal<uint>(156, soda.Calories);
        }
        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
            Assert.Equal<uint>(208, soda.Calories);
        }
        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            List<string> Ingredients = soda.Ingredients;
            Assert.Contains<string>("Water", Ingredients);
            Assert.Contains<string>("Natural Flavors", Ingredients);
            Assert.Contains<string>("Cane Sugar", Ingredients);
        }

        [Fact]
        public void ShouldBeAbleToSetSodasaurusFlavorToChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.SodasaurusFlavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.SodasaurusFlavor);
        }

        [Fact]
        public void ShouldBeAbleToSetSodasaurusFlavorToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.SodasaurusFlavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.SodasaurusFlavor);
        }

        [Fact]
        public void ShouldBeAbleToSetSodasaurusFlavorToVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.SodasaurusFlavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.SodasaurusFlavor);
        }

        [Fact]
        public void ShouldBeAbleToSetSodasaurusFlavorToOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.SodasaurusFlavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.SodasaurusFlavor);
        }

        [Fact]
        public void ShouldBeAbleToSetSodasaurusFlavorToCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.SodasaurusFlavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.SodasaurusFlavor);
        }

        [Fact]
        public void ShouldBeAbleToSetSodasaurusFlavorToRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.SodasaurusFlavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.SodasaurusFlavor);
        }

        [Fact]
        public void ShouldBeAbleToSetSodasaurusFlavorToLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.SodasaurusFlavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.SodasaurusFlavor);
        }
    }  
}
