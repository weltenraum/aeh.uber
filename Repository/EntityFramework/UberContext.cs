using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace aeh.uber.Repository.EntityFramework
{
    public class UberContext : DbContext
    {
        public UberContext(DbContextOptions options) : base(options)
        {
        }

        protected UberContext()
        {
        }

        public DbSet<AboutMe> AboutMes { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Keytopic> Keytopics { get; set; }
        public DbSet<SkillGroup> SkillGroups { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("This isn't a valid connectionstring...");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Experience>()
                .HasMany(e => e.Keytopics)
                .WithOne(k => k.Experience);

            builder.Entity<Experience>()
                .HasMany(e => e.Tags)
                .WithOne(t => t.Experience);

            base.OnModelCreating(builder);
        }
    }
}