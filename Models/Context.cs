using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HesapMakinesi.Models
{
    public class Context : DbContext
    {
        public DbSet<Gecmis> Gecmises { get; set; }
            
    }

}