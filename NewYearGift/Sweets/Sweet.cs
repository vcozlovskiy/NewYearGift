using NewYearsGift.SweetsProperty;


namespace NewYearsGift.Sweets
{
    public abstract class Sweet
    {
        public Sugar ConcentrationSugar { get; }
        public virtual Weight Weight { get; protected set; }

        public string SweetName 
        { 
            get;
            protected set;
        }

        public Sweet(float sugarConcentration, float weight)
        {
            Weight = new Weight(weight);
            ConcentrationSugar = new Sugar(sugarConcentration);
        }

        public override string ToString()
        {
            return $"{SweetName}: \n" +
                $"  {ConcentrationSugar},\n" +
                $"  {Weight}";
        }
    }
}