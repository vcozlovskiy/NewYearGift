using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearGift
{
    public static class ParametricSorter
    {
        public enum SortParametrs
        {
            Weight,
            Sugar,
        }
        public static void Sort(this SweetsContiner sweets,
            SortParametrs parametr)
        {
            switch (parametr)
            {
                case SortParametrs.Weight:
                    var continer = from s in sweets.Sweets
                                   orderby s.Weight
                                   select s;

                    sweets.Sweets = new List<Sweet>(continer);
                    break;

                case SortParametrs.Sugar:
                    var coutiner = from s in sweets.Sweets
                                   orderby s.ConcentrationSugar
                                   select s;

                    sweets.Sweets = new List<Sweet>(coutiner);
                    break;
            }
            
        }

    }
}