using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ManyToMany.Models;

namespace ManyToMany.Data
{
    public class ManyToManyContext : DbContext
    {
        public ManyToManyContext (DbContextOptions<ManyToManyContext> options)
            : base(options)
        {
        }

        public DbSet<ManyToMany.Models.Course> Course { get; set; }

        public DbSet<ManyToMany.Models.Student> Student { get; set; }

        public DbSet<ManyToMany.Models.StudentCourse> StudentCourse { get; set; }
    }
}
