using Microsoft.EntityFrameworkCore;
using ProiectDAW.Models;

namespace ProiectDAW.Data
{
    public class DatabaseContext: DbContext
    {

        // One to Many
        public DbSet<Utilizator> Utilizatori { get; set; }
        public DbSet<Fotografie> Fotografii { get; set; }


        // One to One
        public DbSet<Portofel> Portofel { get; set; }


        // Many to Many
        public DbSet<Atractie> Atractii { get; set; }  
        public DbSet<Bilet> Bilete { get; set; }
        public DbSet<Cazare> Cazari { get; set; }
        public DbSet<Facilitate> Facilitati { get; set; }
        public DbSet<Pachet> Pachete { get; set; }
        public DbSet<Rezervare> Rezervari { get; set; }
        public DbSet<RezervareCazare> RezervariCazari { get; set; }
        public DbSet<Vacanta> Vacante { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // One to Many

            builder.Entity<Utilizator>()
                .HasMany(u => u.Fotografie)
                .WithOne(f => f.Utilizator);

            // One to One

            builder.Entity<Utilizator>()
                .HasOne(u => u.Portofel)
                .WithOne(p => p.Utilizator)
                .HasForeignKey<Portofel>(p => p.UtilizatorID);

            // Many to Many

            builder.Entity<Rezervare>().HasKey(r => new { r.VacantaID, r.UtilizatorID });
            builder.Entity<RezervareCazare>().HasKey(rc => new { rc.VacantaID, rc.CazareID });
            builder.Entity<Pachet>().HasKey(p => new { p.CazareID, p.FacilitateID });
            builder.Entity<Bilet>().HasKey(b => new { b.VacantaID, b.AtractieID });

            builder.Entity<Rezervare>()
                .HasOne<Utilizator>(r => r.Utilizator)
                .WithMany(u => u.Rezervare)
                .HasForeignKey(r => r.UtilizatorID);

            builder.Entity<Rezervare>()
                .HasOne<Vacanta>(r => r.Vacanta)
                .WithMany(v => v.Rezervare)
                .HasForeignKey(r => r.VacantaID);

            builder.Entity<RezervareCazare>()
                .HasOne<Vacanta>(rc => rc.Vacanta)
                .WithMany(v => v.RezervareCazare)
                .HasForeignKey(rc => rc.VacantaID);

            builder.Entity<RezervareCazare>()
                .HasOne<Cazare>(rc => rc.Cazare)
                .WithMany(c => c.RezervareCazare)
                .HasForeignKey(rc => rc.CazareID);

            builder.Entity<Pachet>()
                .HasOne<Cazare>(p => p.Cazare)
                .WithMany(c => c.Pachet)
                .HasForeignKey(p => p.CazareID);

            builder.Entity<Pachet>()
                .HasOne<Facilitate>(p => p.Facilitate)
                .WithMany(f => f.Pachet)
                .HasForeignKey(p => p.FacilitateID);

            builder.Entity<Bilet>()
                .HasOne<Vacanta>(b => b.Vacanta)
                .WithMany(v => v.Bilet)
                .HasForeignKey(b => b.VacantaID);

            builder.Entity<Bilet>()
                .HasOne<Atractie>(b => b.Atractie)
                .WithMany(a => a.Bilet)
                .HasForeignKey(b => b.AtractieID);
            base.OnModelCreating(builder);
        }
    }
}
