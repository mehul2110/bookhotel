using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookHotel
{
    
    /// A utility class to store all the current values from the intent's slots.
    public class Reservation
    {
        public string ReservationType { get; set; }

        #region Hotel Resevation Fields

        public string CheckInDate { get; set; }
        public string Location { get; set; }
        public string Nights { get; set; }
        public string RoomType { get; set; }

        [JsonIgnore]
        public bool HasRequiredHotelFields
        {
            get
            {
                return !string.IsNullOrEmpty(CheckInDate)
                        && !string.IsNullOrEmpty(Location)
                        && !string.IsNullOrEmpty(Nights)
                        && !string.IsNullOrEmpty(RoomType);
            }
        }

        #endregion
    }
}
