using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectingToSQLWithEFCore
{
    //Install SQL package, and tools package
    //Add EFCore
    //Open Package Manager-type add-migration CreateSchoolDB,update-database -verbose
    //https://www.entityframeworktutorial.net/efcore/entity-framework-core-console-application.aspx
    class Context : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source = (localdb)\MSSQLLocalDB; Database=SchoolDB; Integrated Security = True; 
            Connect Timeout = 30; Trusted_Connection=True;");
        }
    }
}
