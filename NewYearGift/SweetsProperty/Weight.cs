using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearGift
{
    public class Weight : IComparable
    {
        public float Kilogramms { get; }

        public Weight(float weight)
        {
            if (weight <= 0)
            {
                throw new ArgumentException(nameof(weight) +
                       " - Weigth can't be less 0");
            }
            Kilogramms = weight;
        }

        public override string ToString()
        {
            return new string("Weiht: " + Kilogramms + " gramms");
        }

        public int CompareTo(object obj)
        {
            Weight p = obj as Weight;
            if (p != null)
                return this.Kilogramms.CompareTo(p.Kilogramms);
            else
                throw new Exception("obj is not Weight");
        }
    }
}