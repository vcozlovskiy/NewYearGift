using NewYearsGift.Sweets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewYearsGift.ContinerOfSweets;

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
        } 

        public GumPack(float weaght, float sugarConcentratio,
            int numberOfGums)
               : base(weaght, sugarConcentratio)
        {
            this.SweetName = "Gum pack";

            List<Gum> gumList = new List<Gum>(); 
            
            for (int i = 0; i < numberOfGums; i++)
            {
                gumList.Add(new Gum(weaght,sugarConcentratio));
            }

            Gums = new SweetsContiner();
            numberOfGums = numberOfGums;
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
            return $"Pac of gum: \n" +
                   $"Gums count - {NumberOfGums},\n" +
                   $"Sugar - {ConcentrationSugar},\n" +
                   $"Weigth - {Gums.Sweets[0].Weight.Kilograms * Gums.Sweets.Count}";
        }
    }
}