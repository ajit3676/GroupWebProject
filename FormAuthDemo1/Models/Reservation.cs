using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormAuthDemo1.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int UserId { get; set; } // Foreign Key to User
        public DateTime ReservationDate { get; set; }
        public int NumberOfGuests { get; set; }
        public string SeatingPreference { get; set; } // E.g., "Window", "Booth"
        public string Status { get; set; } // E.g., "Confirmed", "Cancelled"

        public virtual User User { get; set; }
    }
}