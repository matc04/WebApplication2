using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using WebApplication2.Models.Procedures;

namespace WebApplication2.Data
{
    public class WebApplication2DbContext : DbContext
    {
        public WebApplication2DbContext(DbContextOptions<WebApplication2DbContext> options)
        : base(options)
        {
        }


        public DbSet<Intermedia> Intermedia { get; set; }

        public DbSet<Tin_UnderWBook> Tin_UnderWBook { get; set; }

        public DbSet<Tin_DXP> Tin_DXP { get; set; }

        public DbSet<ClientWeb> ClientWeb { get; set; }


        public DbSet<GetTinUnderWBook> GetTinUnderWBook { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tin_UnderWBook>()
                .HasKey(T => new { T.Sorigin, T.Nyear, T.Nmonth, T.Sprovisional, T.Stype, T.Nbranch, T.Npolicy, T.Nid });

            modelBuilder.Entity<Tin_DXP>()
               .HasKey(T => new { T.Sorigin, T.Nyear, T.Ntrimester, T.Sprovisional, T.Nreceipt, T.Npolicy, T.Ncertif });

            ////// configures one-to-many relationship
            modelBuilder.Entity<Intermedia>()
                .HasMany(T => T.Tin_UnderWBooks)
                .WithOne(I => I.Intermedia)
                .IsRequired();

            modelBuilder.Entity<Tin_UnderWBook>()
                .HasOne(I => I.Intermedia)
                .WithMany(T => T.Tin_UnderWBooks);

            modelBuilder.Entity<GetTinUnderWBook>(gt =>
            {
                gt.HasNoKey();
            });
               
            

        }

    }
}
