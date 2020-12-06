using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Comp586ProjectServer.Models
{
    public partial class spa586Context : DbContext
    {
        public spa586Context()
        {
        }

        public spa586Context(DbContextOptions<spa586Context> options)
            : base(options)
        {
        }

        public virtual DbSet<BoardGame> BoardGames { get; set; }        
        public virtual DbSet<Designer> Designers { get; set; }        
        public virtual DbSet<Publisher> Publishers { get; set; }       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoardGame>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Designer>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
