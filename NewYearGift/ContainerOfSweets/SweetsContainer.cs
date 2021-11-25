using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewYearsGift.SortingParametersEnum;
using NewYearsGift.Sweets;

namespace NewYearsGift.ContinerOfSweets
{
    public class SweetsContainer : IEnumerable
    {
        public List<Sweet> Sweets { get; set; }

        public SweetsContainer(IEnumerable<Sweet> fruits)
        {
            Sweets = new List<Sweet>(fruits);
        }
        public SweetsContainer()
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
                    var сontainer = from s in Sweets
                                   orderby s.Weight
                                   select s;

                    Sweets = сontainer.ToList();
                    break;

                case SortParametrs.Sugar:
                    var сontainer1 = from s in Sweets
                                   orderby s.ConcentrationSugar
                                   select s;

                    Sweets = сontainer1.ToList();
                    break;
            }

        }
    }
}