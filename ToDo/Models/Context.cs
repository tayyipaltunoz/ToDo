using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDo.Models
{
    public class Context : DbContext
    {
        public DbSet<Gorev> Gorevler { get; set; }
    }
}