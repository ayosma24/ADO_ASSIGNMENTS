using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FootBall.Models;

namespace FootBall.Models
{
    public class PlayDbContext : DbContext
    {
        public PlayDbContext()
            : base("name=conn")
        {

        }
        public DbSet<Game> Games{ get; set; }
        
    }
}