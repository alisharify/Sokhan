using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sokhan.Models;
using Sokhan.Areas.Admin.Models;

namespace Sokhan.Models
{
    public class SchoolDatabaseContext:DbContext
    {
        public IConfiguration Configuration { get; }
        public SchoolDatabaseContext()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string s = "Server=.;Database=Sokhan;User Id=SA;Password=1234567890;";//Configuration.GetConnectionString("DefaultConnection");
            string s = "Server=.;Database=Sokhan;User Id=SA;Password=1234567890;";// Configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(s);
        }

        //public DbSet<Student> Students { get; set; }

        public DbSet<Sokhan.Models.Student> Student { get; set; }
    }
}
