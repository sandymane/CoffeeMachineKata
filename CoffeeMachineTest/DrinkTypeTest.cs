using System;
using CoffeeMachine;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoffeeMachineTest
{
    [TestClass]
    public class DrinkTypeTest
    {
        [TestMethod]
        public void OrderACoffeeShouldReturnC()
        {
            Order order = new Order("C");
            order.GetDrinkType().Should().Be("C");
        }
    }
}
