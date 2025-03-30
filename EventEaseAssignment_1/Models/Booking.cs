namespace EventEaseAssignment_1.Models
{
    public class Booking
    {
        public int BookingId { get; set; } // Primary Key for the booking
        public int EventId { get; set; } // Foreign Key referring to the event
        public int VenueId { get; set; } // Foreign Key referring to the venue
        public DateTime BookingDate { get; set; } // The date and time when the booking was created
        public string? CustomerName { get; set; } // The name of the customer making the booking
        public string? CustomerEmail { get; set; } // The email address of the customer
        public string? Notes { get; set; } // Optional notes related to the booking (e.g., special requests)
        public string BookingStatus { get; set; } // Status of the booking (e.g., "Confirmed", "Pending")
        public string PaymentStatus { get; set; } // Payment status (e.g., "Paid", "Pending")
        public bool IsDeleted { get; set; } // Soft delete property
        public Event? Event { get; set; } // Navigation property for the associated event
        public Venue? Venue { get; set; } // Navigation property for the associated venue
    }
}
