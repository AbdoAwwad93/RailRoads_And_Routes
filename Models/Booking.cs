﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Transport_system_prototype.Models;

namespace Transport__system_prototype.Models
{
    public class Booking 
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        [ForeignKey("Trip")]
        public int TripId { get; set; }
        public virtual AppUser? User { get; set; }
        public virtual Trip? Trip { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumberOfSeats { get; set; }
        [NotMapped]
        public int ComputedTotalPrice => NumberOfSeats * (Trip?.Price ?? 0);
    }
}
