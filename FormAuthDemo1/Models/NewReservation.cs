using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormAuthDemo1.Models
{
    public class NewReservation
    {
        public int ID { get; set; } // Unique identifier for the reservation
        public int UserID { get; set; } // ID of the user making the reservation (foreign key)
        public int GymClassID { get; set; } // ID of the reserved class (foreign key)
        public DateTime ReservationDate { get; set; } // Date and time when the reservation was made
        public bool IsCancelled { get; set; } // Status of the reservation (active or cancelled)
    }
}