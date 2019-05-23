using System;

namespace CoffeeMachine
{
    public abstract class Order
    {
        protected int NumberOfSugar { get; set; }
        public abstract string TranslateOrder();
    }
}