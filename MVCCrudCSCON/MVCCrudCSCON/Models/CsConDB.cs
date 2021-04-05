using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCCrudCSCON.Models
{
    public class CsConDB:DbContext
    {
        public CsConDB()
        {
            base.Database.Connection.ConnectionString = "server=.; database=BogaziciUni; uid=sa; pwd=YOUR PASSWORD MUST BE HERE";
        }

        public DbSet<Student> Students { get; set; }
    }
}