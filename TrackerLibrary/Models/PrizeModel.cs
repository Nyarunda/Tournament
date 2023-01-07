using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Unique identier for the model
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Position for perticipating team
        /// </summary>
        public int PlaceNo { get; set; }
        /// <summary>
        /// Position name for perticipating team
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// amount this place earned
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// rep the percentage of
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }
        /// <summary>
        /// Overloaded constructor
        /// </summary>
        /// <param name="placeName"></param>
        /// <param name="placeNo"></param>
        /// <param name="prizeAmount"></param>
        /// <param name="prizePercentage"></param>
        public PrizeModel(string placeName, string placeNo, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNo, out placeNumberValue);
            PlaceNo = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
