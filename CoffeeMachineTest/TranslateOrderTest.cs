using System;
using CoffeeMachine;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoffeeMachineTest
{
    [TestClass]
    public class TranslateOrderTest
    {
        [TestMethod]
        public void OrderCoffeeWithoutSugar()
        {
            Order order = new Coffee();
            order.TranslateOrder().Should().Be("C::");
        }

        [TestMethod]
        public void OrderCoffeeWith1Sugar()
        {
            Order order = new Coffee(1);
            order.TranslateOrder().Should().Be("C:1:0");
        }

        [TestMethod]
        public void OrderCoffeeWith2Sugar()
        {
            Order order = new Coffee(2);
            order.TranslateOrder().Should().Be("C:2:0");
        }

        [TestMethod]
        public void OrderChocoloateWithoutSugar()
        {
            Order order = new Chocolate();
            order.TranslateOrder().Should().Be("H::");
        }

        [TestMethod]
        public void OrderChocolateWith1Sugar()
        {
            Order order = new Chocolate(1);
            order.TranslateOrder().Should().Be("H:1:0");
        }

        [TestMethod]
        public void OrderChocolateWith2Sugar()
        {
            Order order = new Chocolate(2);
            order.TranslateOrder().Should().Be("H:2:0");
        }

        [TestMethod]
        public void OrderTeaWithoutSugar()
        {
            Order order = new Tea();
            order.TranslateOrder().Should().Be("T::");
        }

        [TestMethod]
        public void OrderTeaWith1Sugar()
        {
            Order order = new Tea(1);
            order.TranslateOrder().Should().Be("T:1:0");
        }

        [TestMethod]
        public void OrderTeaWith2Sugar()
        {
            Order order = new Tea(2);
            order.TranslateOrder().Should().Be("T:2:0");
        }
    }
}
