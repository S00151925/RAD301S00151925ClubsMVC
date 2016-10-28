using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RAD301S00151925Clubs.Models.ClubModel
{
    public class ClubModeldbContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubEvent> Event { get; set; }
        public DbSet<Member> members { get; set; }

        public ClubModeldbContext() : base("DefaultConnection")
        {

        }
    }
}