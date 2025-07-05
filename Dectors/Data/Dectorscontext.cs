using Dectors.Moodle;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dectors.Data
{
    public class Dectorscontext:DbContext
    {
        public virtual DbSet<dector> dectors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = Dectors; Integrated Security = True; Encrypt = False; Trust Server Certificate = True");

        }
    }
}
