using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OneToMany.Models;

namespace OneToMany.Data
{
    public class OneToManyContext : DbContext
    {
        public OneToManyContext (DbContextOptions<OneToManyContext> options)
            : base(options)
        {
        }

        public DbSet<OneToMany.Models.Category> Category { get; set; }

        public DbSet<OneToMany.Models.Product> Product { get; set; }
    }
}
