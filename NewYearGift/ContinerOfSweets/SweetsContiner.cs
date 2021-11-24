using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewYearsGift.SortingParameters;
using NewYearsGift.Sweets;

namespace NewYearsGift.ContinerOfSweets
{
    public class SweetsContiner : IEnumerable
    {
        public List<Sweet> Sweets { get; set; }

        public SweetsContiner(IEnumerable<Sweet> fruits)
        {
            Sweets = new List<Sweet>(fruits);
        }
        public SweetsContiner()
        {
            Sweets = new List<Sweet>();
        }

        public IEnumerator GetEnumerator()
        {
            return Sweets.GetEnumerator();
        }

        public void Sort(SortParametrs parameter)
        {
            switch (parameter)
            {
                case SortParametrs.Weight:
                    var continer = from s in Sweets
                                   orderby s.Weight
                                   select s;

                    Sweets = continer.ToList();
                    break;

                case SortParametrs.Sugar:
                    var coutiner = from s in Sweets
                                   orderby s.ConcentrationSugar
                                   select s;

                    Sweets = coutiner.ToList();
                    break;
            }

        }
    }
}