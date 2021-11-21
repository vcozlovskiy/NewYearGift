using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearGift
{
    public abstract class Sweet
    {
        public Sugar ConcentrationSugar { get; }
        public Weight Weight { get; }

        public Sweet(float sugarConcentration, float weight)
        {
            Weight = new Weight(weight);
            ConcentrationSugar = new Sugar(sugarConcentration);
        }
    }
}