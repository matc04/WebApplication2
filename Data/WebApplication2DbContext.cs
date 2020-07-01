using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class WebApplication2DbContext : DbContext
    {
        public WebApplication2DbContext(DbContextOptions<WebApplication2DbContext> options)
        : base(options)
        {
        }

        public DbSet<Tin_UnderWBook> Tin_UnderWBook { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tin_UnderWBook>()
                .HasKey(T => new { T.Sorigin, T.Nyear, T.Nmonth, T.Sprovisional, T.Stype, T.Nbranch, T.Npolicy, T.Nid });
        }

    }
}
