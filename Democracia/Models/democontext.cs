using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Democracia.Models
{
    public class democontext: DbContext
    {
        public democontext():base("DefaultConnection")
        {

        }
        public DbSet<State> States { get; set; }
    }
}