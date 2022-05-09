using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BusAssignment.Models
{
    public class TravelDbContext : DbContext
    {
        public TravelDbContext()
            : base("name=conn")
        {

        }

        public DbSet<Travel> Travels { get; set; }
    }
}