using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lesson05.Models;

namespace Lesson05.Data
{
    public class Lesson05Context : DbContext
    {
        public Lesson05Context (DbContextOptions<Lesson05Context> options)
            : base(options)
        {
        }

        public DbSet<Lesson05.Models.Product> Product { get; set; }
    }
}
