using System;
using System.Collections.Generic;
using System.Linq;

namespace FormAuthDemo1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime ReservationDate { get; set; }
        public int TableNumber { get; set; }

        // Static list to simulate database of reservations
        private static List<Reservation> Reservations = new List<Reservation>();

        public class Reservation
        {
            public DateTime ReservationDate { get; set; }
            public int TableNumber { get; set; }
        }

        // Method to check if a table is available at a specified date and time
        public bool IsTableAvailable(DateTime date, int tableNumber)
        {
            return !Reservations.Any(r => r.TableNumber == tableNumber && r.ReservationDate == date);
        }

        // Method to add a reservation
        public bool AddReservation(DateTime date, int tableNumber)
        {
            if (IsTableAvailable(date, tableNumber))
            {
                Reservations.Add(new Reservation { ReservationDate = date, TableNumber = tableNumber });
                return true;
            }
            return false;
        }
    }
}
