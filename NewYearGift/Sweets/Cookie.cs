namespace NewYearsGift.Sweets
{
    public class Cookie : Sweet
    {
        public Cookie(float weight, float sugarConcentration)
            : base(sugarConcentration, weight)
        {
            this.SweetName = "Cookie";
        }
    }
}
