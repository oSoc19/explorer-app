using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.DAL
{
    public class ExplorerContext : DbContext
    {
        public DbSet<Painting> Painting { get; set; }
        public DbSet<Artist> Artist {get;set;}
        public DbSet<ArtistTranslation> ArtistTranslation {get;set;}
        public DbSet<Language> Language {get;set;}
        public DbSet<PaintingTranslation> PaintingTranslation {get;set;}
        public DbSet<PaintingAudio> PaintingAudio {get;set;}
        public DbSet<PaintingStory> PaintingStory {get;set;}
        public DbSet<Technique> Technique {get;set;}
        public DbSet<Movement> Movement {get;set;}

        public ExplorerContext(DbContextOptions<ExplorerContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>()
            .HasData(
                new Language
                {
                    Id = 1,
                    Code = "FR",
                    Name = "Français"
                },
                new Language
                {
                    Id = 2,
                    Code = "NL",
                    Name = "Nederlands"
                },
                new Language
                {
                    Id = 3,
                    Code = "EN",
                    Name = "English"
                }
            );

            modelBuilder.Entity<Artist>()
            .HasData(
                new Artist
                {
                    Id = 1,
                    FirstName = "Lucas",
                    LastName = "Achtschellinck",
                    Nationality = "Belgian",
                    Birthdate = "1626-01-16",
                    Deathdate = "1699-05-12"
                },
                new Artist
                {
                    Id = 2,
                    FirstName = "Jacob I",
                    LastName = "Van Oost",
                    Nationality = "Belgian",
                    Birthdate = "1603-07-01",
                    Deathdate = "1671-03-03"
                },
                new Artist
                {
                    Id = 3,
                    FirstName = "Jacob II",
                    LastName = "Van Oost",
                    Nationality = "Belgian",
                    Birthdate = "1637",
                    Deathdate = "1713-09-29"
                }
            );

            modelBuilder.Entity<Movement>()
            .HasData(
                new Movement
                {
                    Id = 1
                }
            );

            modelBuilder.Entity<MovementTranslation>()
            .HasData(
                new MovementTranslation
                {
                    Id = 1,
                    MovementId = 1,
                    Name = "Baroque",
                    Description = "Baroque description too lazy to look for it",
                    LanguageId = 1
                }
            );

            modelBuilder.Entity<Technique>()
            .HasData(
                new Technique
                {
                    Id = 1
                }
            );

            modelBuilder.Entity<TechniqueTranslation>()
            .HasData(
                new TechniqueTranslation
                {
                    Id = 1,
                    TechniqueId = 1,
                    Name = "Peinture à l'huile",
                    Description = "Too lazy again",
                    LanguageId = 1
                }
            );

            modelBuilder.Entity<Painting>()
            .HasData(
                new Painting
                {
                    Id = 1,
                    AuthorId = 2,
                    ImageUrl = "http://groeningemuseum.be/collection/work/representation/0000_GRO0184_I",
                    Year = 1668,
                    Height = (float) 116,
                    Width = (float) 222,
                    TechniqueId = 1,
                    MovementId = 1
                }
            );

            modelBuilder.Entity<PaintingTranslation>()
            .HasData(
                new PaintingTranslation
                {
                    Id = 1,
                    PaintingId = 1,
                    LanguageId = 1,
                    Name = "Portrait d’un théologien et son secrétaire",
                    Description = "Once again again lazy"
                }
            );

        }

    }
}
