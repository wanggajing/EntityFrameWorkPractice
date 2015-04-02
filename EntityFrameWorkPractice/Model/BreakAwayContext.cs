using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameWorkPractice.Model
{
    public class BreakAwayContext:DbContext
    {
        public BreakAwayContext() : base("BreakAway") { }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; } 
    }
}