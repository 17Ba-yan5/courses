using courses.moodle;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courses.data
{
    public class coursesContext:DbContext
    {
        public virtual DbSet<course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = courses; Integrated Security = True; Encrypt = False; Trust Server Certificate = True");

        }


    }
}
