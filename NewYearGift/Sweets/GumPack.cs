using NewYearsGift.Sweets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewYearsGift.ContinerOfSweets;
using NewYearsGift.SweetsProperty;

namespace NewYearsGift.Sweets
{
    public class GumPack : Sweet
    {
        private SweetsContiner Gums { get; }

        public int NumberOfGums
        {
            get
            {
                return Gums.Sweets.Count;
            }
            private set
            {

            }
        } 

        public GumPack(float weaght, float sugarConcentratio,
            int numberOfGums)
               : base(weaght, sugarConcentratio)
        {
            this.SweetName = "Pac of gum";

            List<Gum> gumList = new List<Gum>(); 
            
            for (int i = 0; i < numberOfGums; i++)
            {
                gumList.Add(new Gum(weaght,sugarConcentratio));
            }

            Gums = new SweetsContiner();
            NumberOfGums = numberOfGums;
        }

        public Gum GetGum()
        {
            Gum tempGum;

            if (Gums.Sweets.Count > 0)
            {
                tempGum = (Gum)Gums.Sweets[^1];
                return tempGum;
            }
            else
            {
                throw new Exception("Pack is empty");
            }
        }

        public override string ToString()
        {
            return $"{SweetName}: \n" +
                   $"Gums count - {NumberOfGums},\n" +
                   $"Sugar - {ConcentrationSugar},\n" +
                   $"Weigth - {Gums.Sweets[0].Weight.Kilograms}";
        }
    }
}