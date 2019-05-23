namespace CoffeeMachine
{
    public class Chocolate : Order
    {
        public Chocolate()
        {

        }
        public Chocolate(int numberOfSugar)
        {
            this.NumberOfSugar = numberOfSugar;
        }

        public override string TranslateOrder()
        { 
            return "H" + (NumberOfSugar > 0 ? $":{NumberOfSugar}:0"
                  : "::");
        }
    }
}
