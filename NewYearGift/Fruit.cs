using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearGift
{
    public class Fruit : Sweets
    {
        public Fruit(float sugarConcentration)
        {
            if (sugarConcentration > 100 || sugarConcentration < 0)
            {
                throw new ArgumentException(nameof(sugarConcentration) +
                    " - Sugar concentration can't be more 100% or less 0%");
            }
        }
    }
}