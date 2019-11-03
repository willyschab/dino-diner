using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;
using System.Collections.ObjectModel;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void ShouldHaveCorrectPriceForSubTotalCost()
        {
            Order check = new Order();
            Tyrannotea test1 = new Tyrannotea();
            Brontowurst test2 = new Brontowurst();
            Fryceritops test3 = new Fryceritops();
            check.Add(test1);
            check.Add(test2);
            check.Add(test3);
            Assert.True(Math.Abs(7.34 - check.SubTotalCost) < .0000001);
        }

        [Fact]
        public void SubTotalCostShouldNeverBeNegative()
        {
            Order check = new Order();
            Tyrannotea test1 = new Tyrannotea();
            test1.Price = -2;
            Brontowurst test2 = new Brontowurst();
            test2.Price = -2;
            Fryceritops test3 = new Fryceritops();
            test3.Price = -2;
            check.Add(test1);
            check.Add(test2);
            check.Add(test3);
            Assert.True(Math.Abs(6 - check.SubTotalCost) < .00000001);
        }
    }
}
