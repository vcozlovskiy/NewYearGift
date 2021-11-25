using NewYearsGift.Sweets;
using NewYearsGift.SweetsProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearsGift.Sweets
{
    public class StuffedCookie : Cookie, IStuffebly
    {
        public Stuffing Stuffing { get; }
        
        public StuffedCookie(float weight, float sugarConcentration, Stuffing stuffing)
               : base(sugarConcentration, weight)
        {
            this.SweetName = "Stuffed cookie";
            Stuffing = stuffing;
        }
    }
}