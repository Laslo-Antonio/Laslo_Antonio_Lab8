using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Laslo_Antonio_Lab8.Models;

namespace Laslo_Antonio_Lab8.Data
{
    public class Laslo_Antonio_Lab8Context : DbContext
    {
        public Laslo_Antonio_Lab8Context (DbContextOptions<Laslo_Antonio_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Laslo_Antonio_Lab8.Models.Book> Book { get; set; }

        public DbSet<Laslo_Antonio_Lab8.Models.Publisher> Publisher { get; set; }
        public DbSet<Laslo_Antonio_Lab8.Models.Category> Category { get; set; }
        public DbSet<Laslo_Antonio_Lab8.Models.BookCategory> BookCategory { get; set; }
    }
}
