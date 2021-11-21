using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearGift
{
    public class SweetsContiner
    {
        List<Sweets> Sweets { get; }
        
        public SweetsContiner(List<Fruit> fruits)
        {
            Sweets = new List<Sweets>(fruits);
        }

        public SweetsContiner(Fruit[] fruits)
        {
            Sweets = new List<Sweets>(fruits); 
        }
        public SweetsContiner()
        {
            Sweets = new List<Sweets>();
        }
    }
}