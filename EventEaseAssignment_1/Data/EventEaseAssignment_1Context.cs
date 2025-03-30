using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventEaseAssignment_1.Models;

namespace EventEaseAssignment_1.Data
{
    public class EventEaseAssignment_1Context : DbContext
    {
        public EventEaseAssignment_1Context (DbContextOptions<EventEaseAssignment_1Context> options)
            : base(options)
        {
        }

        public DbSet<EventEaseAssignment_1.Models.Venue> Venue { get; set; } = default!;
        public DbSet<EventEaseAssignment_1.Models.Event> Event { get; set; } = default!;
        public DbSet<EventEaseAssignment_1.Models.Booking> Booking { get; set; } = default!;
    }
}
