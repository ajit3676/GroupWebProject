using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormAuthDemo1.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public string ReservationName { get; set; }
        public int NoOfGuests { get; set; }
        public string Remarks { get; set; }
        public string SeatingPreference { get; set; }

        public String ReservationDate { get; set; }
        public String ReservationTime { get; set; }

    }
}