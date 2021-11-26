namespace NewYearsGift.Sweets
{
    public class ChocolateBar : Sweet
    {
        public ChocolateBar(float weight, float sugarConcentration)
               : base(weight, sugarConcentration)
        {
            this.SweetName = "Chocolate bar";
        }
    }
}