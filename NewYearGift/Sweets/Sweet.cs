using NewYearsGift.SweetsProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace NewYearsGift.Sweets
{
    public abstract class Sweet
    {
        public Sugar ConcentrationSugar { get; }
        public Weight Weight { get; }

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