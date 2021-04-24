using Microsoft.EntityFrameworkCore;
using SpareParts.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpareParts.Data.AppDbContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<account>()
                .HasKey(x => x.new_account_id);
            modelBuilder.Entity<department>()
                .HasKey(x => x.new_department_id);
        }

        public DbSet<account> new_account { get; set; }
        public DbSet<department> new_department { get; set; }
    }
}
