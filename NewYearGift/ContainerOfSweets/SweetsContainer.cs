using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NewYearsGift.SortingParametersEnum;
using NewYearsGift.Sweets;

namespace NewYearsGift.ContinerOfSweets
{
    public class SweetsContainer<TSweet> : IEnumerable where TSweet : Sweet
    {
        private List<TSweet> Sweets { get; set; }
        public int Count 
        { 
            get
            {
                return Sweets.Count;
            }
        }

        public TSweet this[int index]
        {
            get
            {
                return Sweets[index];
            }
            set
            {
                Sweets[index] = value;
            }
        }

        public SweetsContainer(IEnumerable<TSweet> sweets)
        {
            Sweets = sweets.ToList();
        }
        public SweetsContainer()
        {
            Sweets = new List<TSweet>();
        }

        public IEnumerator GetEnumerator()
        {
            return Sweets.GetEnumerator();
        }

        public void Add(TSweet sweet)
        {
            Sweets.Add(sweet);
        }

        public void Remove(TSweet sweet)
        {
            Sweets.Remove(sweet);
        }

        public TSweet First()
        {
            return Sweets.First();
        }

        public TSweet Last()
        {
            return Sweets.Last();
        }

        public int IndexOf(TSweet sweet)
        {
            return Sweets.IndexOf(sweet);
        }

        public void Sort(SortParameters parameter)
        {
            switch (parameter)
            {
                case SortParameters.Weight:
                    var сontainer = from s in Sweets
                                   orderby s.Weight
                                   select s;

                    Sweets = сontainer.ToList();
                    break;

                case SortParameters.Sugar:
                    var сontainer1 = from s in Sweets
                                   orderby s.ConcentrationSugar
                                   select s;

                    Sweets = сontainer1.ToList();
                    break;
            }

        }
    }
}