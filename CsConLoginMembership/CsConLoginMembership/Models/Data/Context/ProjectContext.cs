using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CsConLoginMembership.Models.Entities;

namespace CsConLoginMembership.Models.Data.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=CsConLoginDB;User Id=sa; Password=YOUR PASSWORD MUST BE HERE";
        }

        public DbSet<ApplicationUser> User { get; set; }
    }
}