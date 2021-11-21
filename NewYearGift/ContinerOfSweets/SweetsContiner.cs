using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearGift
{
    public class SweetsContiner : IEnumerable
    {
        public List<Sweets> Sweets { get; }

        public SweetsContiner(IEnumerable<Sweets> fruits)
        {
            Sweets = new List<Sweets>(fruits);
        }
        public SweetsContiner()
        {
            Sweets = new List<Sweets>();
        }

        public IEnumerator GetEnumerator()
        {
            return Sweets.GetEnumerator();
        }
    }
}