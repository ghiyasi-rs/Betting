using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Bet
    {
        public Bet(int amount)
        {
            this.Award = Game(amount);
        }
        public double Award { get; set; }
        public int Amount { get; set; }


        public double Game(int amount)
        {
            Double awardPercent;
            Random randomChance = new Random();
            int chance = randomChance.Next(1, 100);

            switch (
                    chance <= 50 ? "Loss" :                   //if chance is 1-50 result is loss
                    chance < 91 && chance > 50 ? "Win40" :    //if chance is 51-90 result is win40
                    chance >= 91 ? "Win10" : "Invalid")         //if chance is 91-100 result is win10

            {
                case "Loss":
                    {
                        Award = 0;
                        break;
                    }

                case "Win40":
                    {

                        Random randomAward = new Random();
                        awardPercent = RandomDouble(randomAward, 0, 2);
                        Award = Math.Round(awardPercent * amount, 2);
                        break;
                    }

                case "Win10":
                    {
                        Random randomAward = new Random();
                        awardPercent = RandomDouble(randomAward, 0, 10);
                        Award = Math.Round(awardPercent * amount, 2);
                        break;
                    }


            }
            return Award;
        }

        public double RandomDouble(Random random, double minValue, double maxValue)
        {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }


    }
}
