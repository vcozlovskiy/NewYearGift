using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearsGift.SweetsProperty
{
    public class Sugar : IComparable
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
            return $"Sugar concentration: {Concentration} %";
        }

        public int CompareTo(object obj)
        {
            Sugar p = obj as Sugar;
            if (p != null)
                return this.Concentration.CompareTo(p.Concentration);
            else
                throw new Exception("obj is not Weight");
        }
    }
}