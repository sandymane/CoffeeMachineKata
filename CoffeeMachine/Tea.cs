namespace CoffeeMachine
{
    public class Tea : Order
    {
        public Tea()
        {

        }

        public Tea(int numberOfSugar)
        {
            this.NumberOfSugar = numberOfSugar;
        }

        public override string TranslateOrder()
        { 
            return "T" + (NumberOfSugar > 0 ? $":{NumberOfSugar}:0"
                  : "::");
        }
    }
}
