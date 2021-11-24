using NewYearsGift.Sweets;
using NewYearsGift.SweetsProperty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewYearsGift.Sweets
{
    public class StaffedCookie : Cookie, IStuffebly
    {
        public Stuffing Stuffing { get; }
        
        public StaffedCookie(float weight, float sugarConcentration, Stuffing stuffing)
               : base(sugarConcentration, weight)
        {
            this.SweetName = "Staffed cookie";
            Stuffing = stuffing;
        }
    }
}