using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearGift
{
    public class Weight
    {
        public float Kilogramms { get; }
        public Weight(float weight)
        {
            if (weight < 0)
            {
                throw new ArgumentException(nameof(weight) +
                       " - Weigth can't be less 0");
            }
        }

        public override string ToString()
        {
            return new string("Weiht:" + Kilogramms + " kg");
        }
    }
}