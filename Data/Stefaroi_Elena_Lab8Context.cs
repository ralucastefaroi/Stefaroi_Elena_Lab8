using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stefaroi_Elena_Lab8.Models;

namespace Stefaroi_Elena_Lab8.Data
{
    public class Stefaroi_Elena_Lab8Context : DbContext
    {
        public Stefaroi_Elena_Lab8Context (DbContextOptions<Stefaroi_Elena_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Stefaroi_Elena_Lab8.Models.Book> Book { get; set; }

        public DbSet<Stefaroi_Elena_Lab8.Models.Publisher> Publisher { get; set; }
    }
}
