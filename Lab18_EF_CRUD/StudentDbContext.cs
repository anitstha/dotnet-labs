using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18_EF_CRUD
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext() : base("StudentDbConnection")
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
