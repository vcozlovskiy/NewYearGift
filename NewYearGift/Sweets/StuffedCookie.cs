using NewYearsGift.SweetsProperty;

namespace NewYearsGift.Sweets
{
    public class StuffedCookie : Cookie, IStuffebly
    {
        public Stuffing Stuffing { get; }
        
        public StuffedCookie(float weight, float sugarConcentration, StuffingEnum stuffing)
               : base(sugarConcentration, weight)
        {
            this.SweetName = "Stuffed cookie";
            Stuffing = new Stuffing(stuffing);
        }
    }
}