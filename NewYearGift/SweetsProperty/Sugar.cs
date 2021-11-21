using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearGift
{
    public class Sugar
    {
        public float Concentration { get; }

        public Sugar(float sugarConcentration)
        {
            if (sugarConcentration > 100 || sugarConcentration < 0)
            {
                throw new ArgumentException(nameof(sugarConcentration) +
                    " - Sugar concentration can't be more 100% or less 0%");
            }

            Concentration = sugarConcentration;
        }

        public override string ToString()
        {
            return new string("Sugar concentration: " + Concentration + " %");
        }
    }
}