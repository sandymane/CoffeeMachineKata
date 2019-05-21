using System;

namespace CoffeeMachine
{
    public class Order
    {
        private string v;

        public Order(string v)
        {
            this.v = v;
        }

        public object GetDrinkType()
        {
            return "C";
        }
    }
}