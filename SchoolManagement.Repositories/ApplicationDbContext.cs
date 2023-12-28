using Microsoft.EntityFrameworkCore;
using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Subject> Subject { get; set; }

        public DbSet<Teacher> Teacher { get; set; }

        public DbSet<Student> Student { get; set; }

        public DbSet<Session> Session { get; set; }

        public DbSet<GradeSubject> GradeSubject { get; set; }

        public DbSet<Grade> grades { get; set; }

        public DbSet<AppicationUser> appicationUsers { get; set; }
    }
}
