namespace NewYearsGift.Sweets
{
    public class Gum : Sweet
    {
        public Gum(float weight, float sugarConcentration)
               : base(weight, sugarConcentration)
        {
            this.SweetName = "Gum";
        }
    }
}