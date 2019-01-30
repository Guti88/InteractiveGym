namespace WebApplication2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<cwiczenie> cwiczenie { get; set; }
        public virtual DbSet<dostep> dostep { get; set; }
        public virtual DbSet<osoba> osoba { get; set; }
        public virtual DbSet<progress> progress { get; set; }
        public virtual DbSet<rola> rola { get; set; }
        public virtual DbSet<trening> trening { get; set; }
        public virtual DbSet<archiwum> archiwum { get; set; }
        public virtual DbSet<trening_cwiczenia> trening_cwiczenia { get; set; }
        public virtual DbSet<uzytkownik_progress> uzytkownik_progress { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cwiczenie>()
                .Property(e => e.nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<cwiczenie>()
                .Property(e => e.typ)
                .IsUnicode(false);

            modelBuilder.Entity<cwiczenie>()
                .Property(e => e.sprzęt)
                .IsUnicode(false);

            modelBuilder.Entity<cwiczenie>()
                .HasMany(e => e.trening_cwiczenia)
                .WithRequired(e => e.cwiczenie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dostep>()
                .Property(e => e.nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<dostep>()
                .HasMany(e => e.rola)
                .WithMany(e => e.dostep)
                .Map(m => m.ToTable("rola-dostep").MapLeftKey("idDostep").MapRightKey("idRola"));

            modelBuilder.Entity<osoba>()
                .Property(e => e.imie)
                .IsUnicode(false);

            modelBuilder.Entity<osoba>()
                .Property(e => e.nazwisko)
                .IsUnicode(false);

            modelBuilder.Entity<osoba>()
                .Property(e => e.mail)
                .IsUnicode(false);

            modelBuilder.Entity<osoba>()
                .Property(e => e.telefon)
                .IsUnicode(false);

            modelBuilder.Entity<osoba>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<osoba>()
                .Property(e => e.haslo)
                .IsUnicode(false);

            modelBuilder.Entity<osoba>()
                .HasMany(e => e.archiwum)
                .WithRequired(e => e.osoba)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<osoba>()
                .HasMany(e => e.uzytkownik_progress)
                .WithRequired(e => e.osoba)
                .HasForeignKey(e => e.idUzytkownika)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<progress>()
                .Property(e => e.nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<progress>()
                .HasMany(e => e.uzytkownik_progress)
                .WithRequired(e => e.progress)
                .HasForeignKey(e => e.idProgressu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<rola>()
                .Property(e => e.Nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<rola>()
                .HasMany(e => e.osoba)
                .WithRequired(e => e.rola)
                .HasForeignKey(e => e.rola_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<trening>()
                .Property(e => e.nazwa)
                .IsUnicode(false);

            modelBuilder.Entity<trening>()
                .Property(e => e.typ)
                .IsUnicode(false);

            modelBuilder.Entity<trening>()
                .HasMany(e => e.archiwum)
                .WithRequired(e => e.trening)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<trening>()
                .HasMany(e => e.trening_cwiczenia)
                .WithRequired(e => e.trening)
                .WillCascadeOnDelete(false);
        }
    }
}
