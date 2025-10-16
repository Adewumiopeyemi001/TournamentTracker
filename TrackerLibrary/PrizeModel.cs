using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// The numerica identifier for the place
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The friendly name for the place (second place, first runner up etc)
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The fixed amount this place earns or zero if it is not used
        /// </summary>
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }
        //public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        //{
        //    PlaceName = placeName;

        //    //int placeNumberValue = 0;
        //    int.TryParse(placeNumber, out int placeNumberValue);
        //    placeNumber = placeNumberValue;

        //    decimal prizeAmountValue = 0;
        //    decimal.TryParse(prizeAmount, out prizeAmountValue);
        //    prizeAmount = prizeAmountValue;

        //    decimal prizePercentageValue = 0;
        //    decimal.TryParse(prizePercentage, out prizePercentageValue);
        //    prizePercentage = prizePercentageValue;
        //}

        public PrizeModel(string placeName, string placeNumber, string placeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int.TryParse(placeNumber, out int placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal.TryParse(placeAmount, out decimal placeAmountValue);
            PrizeAmount = placeAmountValue;

            double.TryParse(prizePercentage, out double prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }

   
}
