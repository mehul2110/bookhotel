using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace BookHotel
{    public static class TypeValidators
    {
       
        public static readonly ImmutableArray<string> VALID_CITES = ImmutableArray.Create<string>(new string[]{ "new delhi", "mumbai", "chennai", "kolkata",
            "amritsar", "chandigarh", "ahemdabad", "bangaluru", "pune", "hyderabad", "jaipur", "surat", "kochi", "bhopal", "lucknow", "varanasi", "indore",
            "agra", "kanpur", "patna", "nagpur", "allahbad", "nashik", "guwahati", "ladhak", "shimla", "nanital" });

        public static bool IsValidCity(string city)
        {
            return VALID_CITES.Contains(city.ToLower());
        }


        public static readonly ImmutableArray<string> VALID_ROOM_TYPES = ImmutableArray.Create<string>(new string[] { "queen", "king", "deluxe" });

        public static bool IsValidRoomType(string roomType)
        {
            return VALID_ROOM_TYPES.Contains(roomType.ToLower());
        }
    }
}
