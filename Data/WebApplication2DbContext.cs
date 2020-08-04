using System;
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
            //this.ChangeTracker.LazyLoadingEnabled = true;
        }


        public DbSet<Intermedia> Intermedia { get; set; }

        public DbSet<Tin_UnderWBook> Tin_UnderWBook { get; set; }

        public DbSet<Tin_DXP> Tin_DXP { get; set; }

        public DbSet<ClientWeb> ClientWeb { get; set; }

        public DbSet<GetTinUnderWBook> GetTinUnderWBook { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<Country> Country { get; set; }

        public DbSet<Province> Province { get; set; }

        public DbSet<Locality> Locality { get; set; }

        public DbSet<Municipality> Municipality { get; set; }

        public DbSet<ZipCode> ZipCode { get; set; }


        public DbSet<Persona> Persona { get; set; }

        public DbSet<Direccion> Direccion { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Employee> Employee { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tin_UnderWBook>()
                .HasKey(T => new { T.Sorigin, T.Nyear, T.Nmonth, T.Sprovisional, T.Stype, T.Nbranch, T.Npolicy, T.Nid });

            modelBuilder.Entity<Tin_DXP>()
               .HasKey(T => new { T.Sorigin, T.Nyear, T.Ntrimester, T.Sprovisional, T.Nreceipt, T.Npolicy, T.Ncertif });

            //////// configures one-to-many relationship
            //modelBuilder.Entity<Intermedia>()
            //    .HasMany(T => T.Tin_UnderWBooks)
            //    .WithOne(I => I.Intermedia)
            //    .IsRequired();

            //modelBuilder.Entity<Tin_UnderWBook>()
            //    .HasOne(I => I.Intermedia)
            //    .WithMany(T => T.Tin_UnderWBooks);

            modelBuilder.Entity<GetTinUnderWBook>(gt =>
            {
                gt.HasNoKey();
            });

            ////one-to-many client-address
            //modelBuilder.Entity<ClientWeb>()
            //    .HasMany(A => A.Addresses)
            //    .WithOne(C => C.ClientWeb)
            //    .IsRequired();


            //modelBuilder.Entity<ClientWeb>()
            //    .HasMany(c => c.Addresses)
            //    .WithOne(e => e.ClientWeb)
            //    .IsRequired();

// modelBuilder.Entity<ClientWeb>().HasMany(s => s.Addresses).WithOne(x => x.ClientWeb);

            modelBuilder.Entity<ClientWeb>().HasMany(s => s.Addresses).WithOne(x => x.ClientWeb);


            //modelBuilder.Entity<Employee>()
            //    .HasOne(e => e.Company)
            //    .WithMany(c => c.Employees);

            //modelBuilder.Entity<Address>()
            //   .HasOne(C => C.ClientWeb)
            //   .WithMany(A => A.Addresses);

            ////////one-to-many country-address
            //modelBuilder.Entity<Country>()
            //    .HasMany(A => A.Addresses)
            //    .WithOne(C => C.Country)
            //    .IsRequired();

            ////////one-to-many country-address
            //modelBuilder.Entity<Province>()
            //    .HasMany(A => A.Addresses)
            //    .WithOne(C => C.Province)
            //    .IsRequired();

            //modelBuilder.Entity<Persona>()
            //            .HasMany<Direccion>(g => g.Direcciones)
            //            .WithOne(s => s.Persona);

            //modelBuilder.Entity<Direccion>()
            //            .HasOne(c => c.Persona)
            //            .WithMany(e => e.Direcciones);

            modelBuilder.Entity<Address>()
               .HasOne(C => C.Country)
               .WithMany(A => A.Addresses);

            ////one-to-many country-provinces
            //modelBuilder.Entity<Country>()
            //    .HasMany(P => P.Provinces)
            //    .WithOne(C => C.Country)
            //    .IsRequired();

            //modelBuilder.Entity<Country>()
            //   .HasMany<Province>(g => g.Provinces)
            //   .WithOne(s => s.Country);
            ////   .HasForeignKey(s => s.CountryId);
            ///

            //modelBuilder.Entity<Direccion>()
            //    .HasOne(p => p.Persona)
            //    .WithMany(b => b.Direcciones);

            //modelBuilder.Entity<Persona>()
            //  .HasMany(b => b.Direcciones)
            //  .WithOne(c => c.Persona);

            //modelBuilder.Entity<Persona>()
            //  .HasMany(c => c.Direcciones)
            //  .WithOne(e => e.Persona);

            //modelBuilder.Entity<Province>()
            //.HasOne<Country>(tg => tg.Country)
            //.WithMany(t => t.Provinces)
            //.HasForeignKey(t => t.Country_Id);

            //modelBuilder.Entity<Province>()
            //    .HasOne(c => c.Country)
            //    .WithMany(p => p.Provinces)
            //    .HasForeignKey(p => p.CountryId)
            //    .IsRequired();
            //;

            //modelBuilder.Entity<Country>()
            //    .HasMany(b => b.Provinces)
            //    .WithOne(c => c.Country);

            modelBuilder.Entity<Province>()
               .HasOne(C => C.Country)
               .WithMany(P => P.Provinces);

            //////one-to-many country-provinces
            //modelBuilder.Entity<Province>()
            //    .HasMany(P => P.Localities)
            //    .WithOne(C => C.Province)
            //    .IsRequired();

            base.OnModelCreating(modelBuilder);
        }

        public static implicit operator WebApplication2DbContext(ApplicationDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}
