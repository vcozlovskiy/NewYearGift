using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearGift
{
    public class SweetsContiner : IEnumerable
    {
        public List<Sweet> Sweets { get; }

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
    }
}