namespace CoffeeMachine
{
    public class Coffee : Order
    {
        public Coffee()
        {
        }

        public Coffee(int numberOfSugar)
        {
            this.NumberOfSugar = numberOfSugar;
        }

        public override string TranslateOrder()
        { 
            return "C" + (NumberOfSugar > 0 ? $":{NumberOfSugar}:0"
                  : "::");
        }
    }
}
