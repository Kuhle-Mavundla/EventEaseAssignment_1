namespace EventEaseAssignment_1.Models
{
    public class Venue
    {
        public int VenueId { get; set; } // Primary Key for the venue
        public string VenueName { get; set; } // Name of the venue (e.g., "Grand Hall")
        public string Location { get; set; } // Location of the venue (e.g., "Downtown, CityName")
        public int Capacity { get; set; } // Maximum number of people the venue can accommodate
        public string? ImageUrl { get; set; } // Optional URL for an image representing the venue
        public string? ContactEmail { get; set; } // Contact email for the venue
        public string? PhoneNumber { get; set; } // Contact phone number for the venue
        public bool IsActive { get; set; } // Whether the venue is active for bookings (soft delete)
        public bool IsDeleted { get; set; } // Soft delete property
        public ICollection<Event>? Events { get; set; } // Navigation property for the events associated with this venue
    }
}
