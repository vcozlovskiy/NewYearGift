using System;

namespace NewYearsGift.SweetsProperty
{
    public class Weight : IComparable
    {
        public float Kilograms { get; }

        public Weight(float weight)
        {
            if (weight <= 0)
            {
                throw new ArgumentException(nameof(weight) +
                       " - Weight can't be less 0");
            }
            Kilograms = weight;
        }

        public override string ToString()
        {
            return $"Weiht: {Kilograms} gramms";
        }

        public int CompareTo(object obj)
        {
            Weight p = obj as Weight;
            if (p != null)
                return this.Kilograms.CompareTo(p.Kilograms);
            else
                throw new Exception("obj is not Weight");
        }
    }
}