using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;

namespace MoviesAPI
{
    public partial class MoviesDBContext : DbContext
    {
        public MoviesDBContext()
        {

        }
        public MoviesDBContext(DbContextOptions<MoviesDBContext> options) : base(options)
        {

        }
        public virtual DbSet<MoviesInTheaters> MoviesInTheaters { get; set; }
        public virtual DbSet<MoviesComingSoonDB> moviesComingSoonDB { get; set; }
        public virtual DbSet<Profile> profile { get; set; }
        public virtual DbSet<TopRatedIndian1> topRatedIndian1 { get; set; }
        public virtual DbSet<TopRatedIndian2> topRatedIndian2 { get; set; }
        public virtual DbSet<TopRatedMovies1> topRatedMovies1 { get; set; }
        public virtual DbSet<TopRatedMovies2> topRatedMovies2 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TopRatedMovies2>(entity =>
            {
                entity.Property(e => e.title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.year).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.genres).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.ratings).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.poster).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.contentRating).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.duration).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.releaseDate).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.averageRating).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.originalTitle).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.storyline).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.actors).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.imdbRating).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.posterurl).HasMaxLength(50).IsUnicode(false);
            });
            modelBuilder.Entity<MoviesComingSoonDB>(entity =>
            {
                entity.Property(e => e.title).IsRequired().HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.year).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.genres).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.ratings).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.poster).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.contentRating).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.duration).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.releaseDate).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.averageRating).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.originalTitle).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.storyline).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.actors).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.imdbRating).HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.posterurl).HasMaxLength(50).IsUnicode(false);
            });
            modelBuilder.Entity<Profile>(entity =>
            {
                entity.Property(e => e.first_name).IsRequired().HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.last_name).IsRequired().HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.email).IsRequired().HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.password).IsRequired().HasMaxLength(50).IsUnicode(false);
            });


            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
