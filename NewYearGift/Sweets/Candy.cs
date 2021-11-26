namespace NewYearsGift.Sweets
{
    public class Candy : Sweet
    {
        public Candy(float weight, float sugarConcentration) 
            : base(weight, sugarConcentration)
        {
            this.SweetName = "Candy";
        }
    }
}