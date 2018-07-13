using Data_Access_Layer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Access_Layer.Contexts
{
    class AirportContext : DbContext
    {
        public AirportContext()
        { }

        DbSet<Flight> Flights { get; set; }
        DbSet<Crew> Crews { get; set; }
        DbSet<Departure> Departures { get; set; }
        DbSet<Pilot> Pilots { get; set; }
        DbSet<Plane> Planes { get; set; }
        DbSet<PlaneType> PlaneTypes { get; set; }
        DbSet<Stewardess> Stewardesses { get; set; }
        DbSet<Ticket> Tickets { get; set; }
    }
}
