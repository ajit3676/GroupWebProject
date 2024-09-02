using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormAuthDemo1.Models
{
    public class GymClass
    {
        public int ID { get; set; } // Unique identifier for the class
        public string Name { get; set; } // Name of the fitness class (e.g., Yoga, Pilates, HIIT)
        public string Description { get; set; } // Brief description of the class
        public DateTime Schedule { get; set; } // Date and time when the class is scheduled
        public string Instructor { get; set; } // Name of the instructor leading the class
        public int Duration { get; set; } // Duration of the class in minutes
        public int Capacity { get; set; } // Maximum number of participants allowed in the class
        public decimal Price { get; set; } // Cost to attend the class, if applicable
    }
}